int ledPin1 = 16; //LED 16 Green

int ledPin2 = 17; //LED 17 White

int ledPin3 = 23; //LED 23 Yellow

const int in1Pin = 18; // H-Bridge input pins

const int in2Pin = 19;

// GPIO 18,19 = waterpump

int buzzer-15;

// Buzzer 15 low 1 = high

int analogPin = 2;

int val 0;

void setup() {

// sets the pin as output

pinMode(ledPin1, OUTPUT);

pinMode(ledPin2, OUTPUT);

pinMode(ledPin3, OUTPUT);

pinMode (buzzer, OUTPUT);

pinMode(in1Pin, OUTPUT);

pinMode(in2Pin, OUTPUT);

Serial.begin(9600);

}

void loop() {

delay(500);

val = analogRead(2);

//Serial.print("Humanity Value ");

Serial.print(val);

val = map(val, 4095,1300,0,100);

//Serial.println("%");

if (val < 40) {

//led on and print value

digitalWrite(ledPin3, HIGH);

Serial.print("Humanity Value ");

Serial.print(val);

Serial.println("%");

Serial.println();

//buzzer on

digitalWrite(buzzer, LOW);

//pump on

digitalWrite(in1Pin, LOW);

digitalWrite(in2Pin, LOW);

delay(500);

}

else {

//led and buzzer off

digitalWrite(ledPin3, LOW);

digitalWrite(buzzer, HIGH);

}


if (val > 40 && val < 60) {

//led on and print value

digitalWrite(ledPin2, HIGH);

Serial.print("Humanity Value ");

Serial.print(val);

Serial.println("%");

Serial.println();

//buzzer off

digitalWrite(buzzer, HIGH);

delay(500);

}

else {

//ledand buzzer off

digitalWrite(ledPin2, LOW);

digitalWrite(buzzer, HIGH);

}

if (val > 60) {

//led on and print value

digitalWrite(ledPin1, HIGH);

Serial.print("Humanity Value ");

Serial.print(val);

Serial.println("%");

Serial.println();

//buzzer off

digitalWrite(buzzer, HIGH);

//pump off

digitalWrite(in1Pin, HIGH);

digitalWrite(in2Pin, LOW);

delay(500);

}

else {

//led and buzzer off

digitalWrite(ledPin1, LOW);

digitalWrite(buzzer, HIGH);

}

delay(100);

}