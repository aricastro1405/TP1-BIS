using System.Collections.Generic;
mostrarMenu("1. Ingrese los importes de un curso 2. Ver estadísticas 3. Salir");
int rta=pedirInt("Ingrese el número de la opción que desea ver: ");
Console.Clear();
Dictionary<string,float> importes = new Dictionary<string,float>();
while(rta!=3){
switch (rta){
case 1:
string curso=pedirString("Ingrese el curso: ");
bool yaEsta=importes.ContainsKey(curso);
if (yaEsta){
    Console.WriteLine("Ya ingresaste ese curso.");
}
else {
    int cantEstudiantes=pedirInt("Ingrese la cantidad de estudiantes del curso: ");
    float suma=calcularImporteCurso(cantEstudiantes);
    importes.Add(curso,suma);
}
break;
case 2:
string cursoMasPlata=calcularCursoMasPlata(importes);
Console.WriteLine("El curso que más plata puso es "+cursoMasPlata);
float promedio=calcularPromedio(importes);
Console.WriteLine("El promedio de plata regalada por curso es "+promedio);
float recaudacionTotal=calcularRecaudacionTotal(importes);
Console.WriteLine("La recaudación total entre todos los cursos es "+recaudacionTotal);
int cantCursosRegalo=calcularCursosRegalo(importes);
Console.WriteLine("La cantidad de cursos que participan del regalo son "+cantCursosRegalo);
break;
}
mostrarMenu("1. Ingrese los importes de un curso 2. Ver estadísticas 3. Salir");
rta=pedirInt("Ingrese el número de la opción que desea ver: ");
}
Console.WriteLine("Saliste.");


int calcularCursosRegalo(Dictionary<string,float>importes){
   int devolver=0;
foreach(string curso in importes.Keys){
       devolver++;
       }
         return devolver;
   }

float calcularRecaudacionTotal(Dictionary<string,float>importes){
float devolver=0;
foreach(float suma in importes.Values){
       devolver+=suma;
       }
       return devolver;
   }


float calcularPromedio(Dictionary<string,float>importes){
   float devolver;
   float acum=0;
   int cont=0;
   foreach(float suma in importes.Values){
       acum+=suma;
       cont++;
       }
         devolver=acum/cont;
   return devolver;

   }

string calcularCursoMasPlata(Dictionary<string,float>importes){
   string devolver="";
   float aux=0;
   foreach(string curso in importes.Keys){
       if (importes[curso]>aux){
       aux=importes[curso];
       devolver=curso;
       }
   }
   return devolver;
}


float calcularImporteCurso(int cantEstudiantes){
   float devolver=0,i=0,importeAlumno=0;
   while(i<cantEstudiantes){
       importeAlumno=pedirInt("Ingrese lo que el alumno "+(i+1)+" va a poner: ");
       devolver+=importeAlumno;
       i++;
   }
   return devolver;
}


string pedirString(string mensaje){
   string devolver;
   Console.WriteLine(mensaje);
   devolver=Console.ReadLine();
   return devolver;
}

int pedirInt(string mensaje){
  int devolver=0;
  Console.WriteLine(mensaje);
  devolver=int.Parse(Console.ReadLine());
  return devolver;
}


void mostrarMenu(string mensaje){
   Console.WriteLine(mensaje);
}