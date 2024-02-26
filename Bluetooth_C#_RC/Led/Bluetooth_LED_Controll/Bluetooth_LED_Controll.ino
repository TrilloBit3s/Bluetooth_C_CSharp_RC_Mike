//CÓDIGO SERVE PARA AUTOMAÇÃO E CARRINHO BLUETOOTH
//ULTIMA ATUALIZAÇÃO 26//11/2023
//TA FICANDO FODASTICO CARAIIII

int caracterBT = 0;

int LED1=4;
int LED2=7;
int LED3=8;
int LED4=12;

int motorn1=3; //PWM
int motorn2=5; //PWM
int motorn3=6; //PWM
int motorn4=9; //PWM
int ENA=10; //PWM
int ENB=11; //PWM

int vSpeed = 255;//Define velocidade padrão 0 a 255.

void setup() 
{
  Serial.begin(9600);
 
  pinMode(LED1,OUTPUT);
  pinMode(LED2,OUTPUT);
  pinMode(LED3,OUTPUT);
  pinMode(LED4,OUTPUT);

  pinMode(motorn1, OUTPUT);
  pinMode(motorn2, OUTPUT);
  pinMode(motorn3, OUTPUT);
  pinMode(motorn4, OUTPUT);
  pinMode(ENA, OUTPUT);
  pinMode(ENB, OUTPUT);

  pinMode(motorn1, LOW);
  pinMode(motorn2, LOW);
  pinMode(motorn3, LOW);
  pinMode(motorn4, LOW);
  pinMode(ENA, LOW);
  pinMode(ENB, LOW);
}

//TESTAR METODOS KKKKKKKKK
//SE NÃO ISSO VAI FICAR INFINITO
void loop() 
{
  analogWrite(ENA, 200); //velovidade do motor esquerdo
  analogWrite(ENB, 200); //velovidade do motor direito
  
  if(Serial.available()) 
     {
        caracterBT= Serial.read();
        //VARIAVEIS PARA LUZES COMEÇA AQUI
         if(caracterBT==1)
          {
            digitalWrite (LED1, HIGH);
          }
          else if(caracterBT==2)
          {
            digitalWrite (LED1, LOW);
          }
          else if(caracterBT==3)
          {
            digitalWrite (LED2, HIGH);
          }
          else if(caracterBT==4)
          {
            digitalWrite (LED2, LOW);
          }
          else if(caracterBT==5)
          {
            digitalWrite (LED3, HIGH);
          }
          else if(caracterBT==6)
          {
            digitalWrite (LED3, LOW);
          }
          else if(caracterBT==7)
          {
            digitalWrite (LED4, HIGH);
          }
          else if(caracterBT==8)
          {
            digitalWrite (LED4, LOW);
          }
          //VARIAVEIS PARA LUZES TERMINA AQUI

          //VARIAVEIS PARA MOTORES "PWM" COMEÇA AQUI
          else if(caracterBT==9)// MOTOR DIREITA SENTIDO HORARIO "F"
          {
            //digitalWrite (motorn1, LOW);
            digitalWrite (motorn2, vSpeed);
            digitalWrite (motorn3, vSpeed);
            //digitalWrite (motorn4, LOW);
          }
          else if(caracterBT==10)// MOTOR DIREITA PARA "S"
          {
            digitalWrite (motorn1, LOW);
            digitalWrite (motorn2, LOW);
            digitalWrite (motorn3, LOW);
            digitalWrite (motorn4, LOW);
          }
          else if(caracterBT==11)// MOTOR DIREITA SENTIDO ANTI-HORARIO "B"
          {
            digitalWrite (motorn1, vSpeed);
            //digitalWrite (motorn2, LOW);
            //digitalWrite (motorn3, LOW);
            digitalWrite (motorn4, vSpeed);
          }
          else if(caracterBT==12)// MOTOR DIREITA PARA  "S"
          {
            digitalWrite (motorn1, LOW);
            digitalWrite (motorn2, LOW);
            digitalWrite (motorn3, LOW);
            digitalWrite (motorn4, LOW);
          }
          else if(caracterBT==13)// MOTOR ESQUERDA SENTIDO HORARIO  "L"
          {
            //digitalWrite (motorn1, LOW);
            digitalWrite (motorn2, vSpeed);
            //digitalWrite (motorn3, LOW);
            digitalWrite (motorn4, vSpeed);
          }
          else if(caracterBT==14)// MOTOR ESQUERDA PARA "S"
          {
            digitalWrite (motorn1, LOW);
            digitalWrite (motorn2, LOW);
            digitalWrite (motorn3, LOW);
            digitalWrite (motorn4, LOW);
          }
          else if(caracterBT==15)// MOTOR ESQUERDA SENTIDO ANTI-HORARIO "R"
          {
            digitalWrite (motorn1, vSpeed);
            //digitalWrite (motorn2, LOW);
            digitalWrite (motorn3, vSpeed);
            //digitalWrite (motorn4, LOW);
          }
          else if(caracterBT==16)// MOTOR ESQUERDA PARA "S"
          {
            digitalWrite (motorn1, LOW);
            digitalWrite (motorn2, LOW);
            digitalWrite (motorn3, LOW);
            digitalWrite (motorn4, LOW);
          }
          //VARIAVEIS PARA MOTORES "PWM" TERMINA AQUI
     }
}