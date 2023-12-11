void setup() {
    Serial.begin(9600);
    pinMode(13, OUTPUT);
}

void loop() {
 
  if(Serial.available())
    {
        String data = Serial.readStringUntil('\n');
 
        
        if (data == "TEST")
        {
            digitalWrite(13, HIGH); delay(300);
            digitalWrite(13, LOW); delay(300);            
            digitalWrite(13, HIGH); delay(300);  
            digitalWrite(13, LOW); delay(300);
            digitalWrite(13, HIGH); delay(300);    
            digitalWrite(13, LOW);
        }

        

        
    }

    // MANDA DATOS AL SERIAL PARA GUARDAR EN BASE DE DATOS
    long r = random(1, 10); 
    Serial.println(r);
}
