

const int CoffeeAvailable = 1;
int Coffee = 0;
String readString;
const long waitTime = 4000;
unsigned long previousMillis = 0;
int prevValue;

void setup(){
  Serial.begin(9600);

  Serial.println("Arduino Doorbell");
  delay(1000);

  pinMode(13,OUTPUT);
  pinMode(3,INPUT);
  
  if (CoffeeAvailable == 1)
  {
    Serial.println("Available Option: Coffee");
  }
  
}

void loop(){

  unsigned long currentMillis = millis();

  // delay for waitTime
  if (currentMillis - previousMillis >= waitTime) {
    previousMillis=currentMillis;  
    Serial.println("Heartbeat");
  } 

  
  int sensorValue=digitalRead(3);
  //Serial.println(sensorValue);
  if ((sensorValue == 0) && (prevValue != sensorValue)) {
    Serial.println("Doorbell Pressed");
    delay(1000);
  }
  prevValue = sensorValue;


  // see if they flipped the coffee switch
  readString = "";
  while (Serial.available()){
     delay(3);
     if (Serial.available()>0){
        char c = Serial.read();
        readString += c;
     }
  }
  readString.trim();
  if (readString == "Coffee"){
    Coffee = 1;
    Serial.println("Ack: Coffee");
  }
  else if (readString == "No Coffee"){
    Coffee = 0;
    Serial.println("Ack: No Coffee");
  }
  else if (readString != "") {
    Serial.print("Unk: ");
    Serial.println(readString);
  }

  if (Coffee == 1){
    digitalWrite(13,HIGH);
  } else {
    digitalWrite(13,LOW);
  }
  
  //delay(1000);
}

