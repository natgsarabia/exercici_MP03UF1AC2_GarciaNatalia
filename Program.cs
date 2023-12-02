internal class Program
{
private static void Main(String[] args)
    {
// TAREA 1
        int nota,media,result;
        result=0;
        for (int i=1; i<=3; i++){
            Console.Write("Escibre la nota del {0} examen :", i);
            nota=Convert.ToInt32(Console.ReadLine());
            result=result+nota;
        }
        media=result/3;
        if (media>=5){
            Console.WriteLine("Estás aprobado.");
        } else
            Console.WriteLine("Estás suspendido");

// TAREA 2
        int num, pares, impares;
        pares=0;
        impares=0;
        do{
            Console.WriteLine("Escriba un número:");
            num=Convert.ToInt32(Console.ReadLine());
            
            if (num %2==0){
                pares=pares+1;
                
            }else
                impares=impares+1;
                

        } while (num!=0);
        Console.WriteLine("Se escribieron {0} numeros pares y {1} números impares", pares-1, impares); //pares-1 para que no sume el 0

// // TAREA 3
int num1, num2, operacion, respuesta, result1;
    

do{
    Console.WriteLine("Introduzca el primer número:");
    num1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduzca el segundo número:");
    num2=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("¿Que operación quiere hacer?");
    Console.WriteLine("Escriba 1 para suma, 2 para resta, 3 para multiplicación o 4 para división: ");
    operacion=Convert.ToInt32(Console.ReadLine());

    switch(operacion)
    {
        case 1:
            result1=num1+num2;
            Console.WriteLine("El resultado de la suma de "+num1+" más "+ num2+" es "+result);
            break;
        case 2:
            result1=num1-num2;
            Console.WriteLine("El resultado de la resta de "+num1+" menos "+ num2+" es "+result);
            break;
        case 3:
            result1=num1*num2;
            Console.WriteLine("El resultado de la multiplicación de "+num1+" y "+ num2+" es "+result);
            break;
        case 4:
            result1=num1/num2;
            Console.WriteLine("El resultado de la división de "+num1+" entre "+ num2+" es "+result);
            break;
        default:
            Console.WriteLine("Ha introducido un número incorrecto");
            break;
     }
    Console.WriteLine("Si desea terminar el programa escriba 0. ");
    respuesta = Convert.ToInt32(Console.ReadLine());

} while (respuesta!=0);
        
// // TAREA 4
        int numDNI, result2;
        do{
            Console.WriteLine("Escribe tu número de DNI: ");
            numDNI=Convert.ToInt32(Console.ReadLine());
            result2=numDNI%23;  
        } while (result!=3);

// TAREA 4
        int altura=15;
        for (int i=1; i<=altura; i++){
            for (int j=1; j<=i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }





// TAREA 5
        for (int i=1; i<=8; i++){
            if (i %2!=0){
                for (int j=1; j<=8; j++){
                    if(j  %2!=0){
                        Console.Write("B");
                    }
                    else{
                        Console.Write("N");
                    }
                }           
            }
            else{
                for (int j=1; j<=8; j++){
                    if (j %2!=0){
                        Console.Write("N");
                    }
                    else{
                        Console.Write("B");
                    }
                }
            }
            Console.WriteLine();
          
        }
        
    } 
}