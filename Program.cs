// See https://aka.ms/new-console-template for more information


/*
registrar los datos correspondientes:
-Nombre del alimento
-Cantidad de calorías
-Tipo de alimento (valor entero, 1=Panes y cereales, 2=Frutas y Verduras, 3=Lácteos y Carnes, 4=Grasas y azúcares)
-Marca que indica si es alimento es de origen orgánico o no. (1 carácter, ‘O’=Es orgánico o ‘N’=No es orgánico).

Luego de cada ingreso de información, el programa debe preguntarle al operador si desea seguir ingresando datos de alimentos o no.

Se pide informar: 
a) Por cada alimento, si el alimento tiene más de 150 calorías, un cartel por pantalla que indique “Alimento no recomendable” , y un cartel que indique “Alimento recomendable”, en caso contrario.**
---------------------------------------------------------------------en lista---------------------------------------------------------------------------------------
b) Cantidad de alimentos orgánicos que sean frutas y verduras. **
c) El nombre del alimento que menos calorías tiene (se supone único), qué tipo de alimento es y ese valor mínimo. **
d) El acumulado total de calorías ingeridas por el paciente, por tipo de alimento.**
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

/*
class Program {

    struct Alimento{
            public string nombreAlimento;
            public int calorias;
            public int tipoAlimento;
            public string organico;
        }

    static List <Alimento> alimentos = new List <Alimento>();



    static void Main(string[] args){

        bool continuarCargando = true;

        do
        {
            Alimento almuerzo = new Alimento();

            //-------------------------------------------------------------------------------------------------------------------------------nombre

            Console.WriteLine("Como se llama el alimento que consumiste?");

            almuerzo.nombreAlimento = Console.ReadLine();

            //-------------------------------------------------------------------------------------------------------------------------------calorias

            Console.WriteLine("Cuantas calorias contiene?");

            almuerzo.calorias = int.Parse(Console.ReadLine());
            if (almuerzo.calorias >= 150)
            {
                Console.WriteLine("alimento no recomendable");
            }else{
                Console.WriteLine("alimento recomendable");
            }

            //-------------------------------------------------------------------------------------------------------------------------------tipo de alimento

            Console.WriteLine("Que tipo de alimento es? (1=Panes y cereales, 2=Frutas y Verduras, 3=Lácteos y Carnes, 4=Grasas y azúcares) indique con el numero");

            almuerzo.tipoAlimento = int.Parse(Console.ReadLine());

            //-------------------------------------------------------------------------------------------------------------------------------organico o no organico

            Console.WriteLine("Es organico? SI/NO");
            almuerzo.organico = Console.ReadLine();

            if (almuerzo.organico == "SI")
            {
                almuerzo.organico = "O";
            }else{
                almuerzo.organico = "N";
            }

            //-------------------------------------------------------------------------------------------------------------------------------final

            Console.WriteLine($"El alimento que usted consumio {almuerzo.nombreAlimento}, {almuerzo.calorias},{almuerzo.organico},{almuerzo.tipoAlimento}");
            
            alimentos.Add(almuerzo);
        

            Console.WriteLine("desea agregar otro alimento? si/no");
            string repuesta = Console.ReadLine();

            

            if (repuesta.ToLower() == "no")
            {
                continuarCargando = false;
            }

            
        } while (continuarCargando);

        Console.WriteLine("Los alimentos ingresados son:");
        int totalCalorias = 0;
        int cantidadAlimentosOr = 0;
        var alimentosOrdenados = alimentos.OrderBy(c => c.calorias);


        foreach (Alimento alimento in alimentosOrdenados) {
            totalCalorias += alimento.calorias;

            Alimento AlimentoUno = alimentosOrdenados.FirstOrDefault();

            string primerAlimento = $"{AlimentoUno.nombreAlimento}, {AlimentoUno.calorias}, {AlimentoUno.tipoAlimento}";

            if (alimento.tipoAlimento == 2)
            {
                cantidadAlimentosOr++;
            }

            Console.WriteLine($"- {alimento.nombreAlimento} ({alimento.calorias} cal) - Tipo: {alimento.tipoAlimento} - Orgánico: {alimento.organico}");

            Console.WriteLine("el alimento con menos calorias es" + " " + primerAlimento);
        }
        Console.WriteLine("el total de calorias es de" + " " + totalCalorias);
        Console.WriteLine("el total de frutas y verduras es de" + " " + cantidadAlimentosOr);
        
    }
}

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                                                cambio de ejercicio

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



/* 
La empresa tiene 5 micros **------
90 km/h vel max **------
Reporta velocidad, número de micro y coordenadas de longitud y latitud **------

ingreso manual:

-Velocidad en km: valor real **-----------
-Número de micro: valor entero de 1 a 5.  **-----------
-Coordenada de latitud en grados: valor entero.  **-----------
-Coordenada de longitud en grados: valor entero. **-----------

--Cuando un micro supera la velocidad permitida en hasta un 15%, se deberá mostrar un mensaje en el sistema central que simule una luz amarilla y el número de micro.**------
--Si supera el 15%, un mensaje que simule una luz roja, el número de micro y las coordenadas de longitud y latitud. **------

Se ingresarán datos hasta que se ingrese número de micro = 0.

Se pide informar: 
a) Cantidad de superaciones rojas por micro. 
b) Promedio de velocidad de superaciones amarillas. 
c) Velocidad máxima en base al reporte de todos los micros, informando además el número de micro que la realizó.


class programa{
    struct Micro{
        public int numeroMicro;
        public int velocidadMicro;
        public int coordenadasLatitud;
        public int coordenadasLongitud;
        public int cantidadLuzAmarilla;
        public int cantidadLuzRoja;
    }

    static List<Micro> micros = new List<Micro>();
    static void Main(string[] args){
       
        bool continuarCargando = true;
        Micro coche = new Micro();


        do
        { 

        Console.WriteLine("Escriba el numero del micro");

        coche.numeroMicro = int.Parse(Console.ReadLine());
         
        if (coche.numeroMicro == 0)
        {
            continuarCargando = false;
        }else
        {
            Console.WriteLine("Escriba las coordenadas de latitud del micro (solo en grados)");

            coche.coordenadasLatitud = int.Parse(Console.ReadLine());

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Escriba las coordenadas de longitud del micro (solo en grados)");

            coche.coordenadasLongitud = int.Parse(Console.ReadLine());

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Escriba la velocidad a la que viaja el micro");

            coche.velocidadMicro = int.Parse(Console.ReadLine());

            if (coche.velocidadMicro > 90 && coche.velocidadMicro <= 90 * 1.15 )
            {
                coche.cantidadLuzAmarilla++;
                Console.WriteLine($"LUZ AMARILLA!!!!!  {coche.numeroMicro}");
            } else if(coche.velocidadMicro > 90 * 1.15)
            {
                coche.cantidadLuzRoja++;
                Console.WriteLine($"LUZ AMARILLA!!!!!  {coche.numeroMicro}, {coche.coordenadasLatitud}, {coche.coordenadasLongitud}");                
            }
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------

            micros.Add(coche);
        }
            
        } while (continuarCargando);

        int cantidad = micros.Count;
        int sumaVelocidades = micros.Sum(p => p.velocidadMicro);
        int sumaLucesAmarillas = micros.Sum(p => p.cantidadLuzAmarilla);
        int sumaLucesRojas = micros.Sum(p => p.cantidadLuzRoja);

        int promedioVelocidad = sumaVelocidades / cantidad;

        foreach (Micro micro in micros)
        {
            Console.WriteLine($"{micro.numeroMicro}, {micro.velocidadMicro}, {micro.cantidadLuzAmarilla}, {micro.cantidadLuzRoja}, {micro.coordenadasLatitud}, {micro.coordenadasLongitud}");
        }

        Console.WriteLine($"{cantidad}, {sumaVelocidades}, {promedioVelocidad}, {sumaLucesAmarillas}, {sumaLucesRojas}");
    }
}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
*/

/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                                                cambio de ejercicio

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*
programa para una estación de peaje
deberá solicitar al operador de la cabina de peaje la categoría del vehículo, el día de la semana, el horario, y el importe de dinero entregado por el conductor del vehículo
Categorías de vehículo: 
-moto 
-auto 
-camioneta 
-camión

Días de la semana: 
-1 (lunes) 
-2 (martes) 
-3 (miércoles) 
-4 (jueves) 
-5 (viernes) 
-6 (sábado) 
-7 (domingo)

Horario: 
-a (pico) 
-b (no pico)

Importes a cobrar:
-Categoría de vehículo: moto – auto – camioneta – camión----------------------
-Valor base de cálculo: 5 – 10 – 15 – 20-------------------------------------
-Lunes a Viernes horario pico: + 20 % a todos------------------------------------
-Lunes a Viernes horario no pico Sábados : monto sin recargo ----------------
-Domingos horario pico o no pico: + 10 % a todos--------------------

El programa le deberá devolver al operador de la cabina de peaje el importe a cobrar (dependiendo de la categoría del vehículo, del día de la semana y del horario), y el vuelto a entregar al conductor del vehículo (dependiendo del importe de dinero entregado por el conductor del vehículo). ---------------------------

Luego de cada venta, el programa debe preguntarle al operador si desea continuar vendiendo ó no.------------------------------

Cuando el operador decida terminar de vender, el programa deberá informar lo siguiente:
-Cantidad de ventas de categoría auto en horario pico -------
-Total de pases vendidos y total recaudado -----------------------------------



class Program{
    struct Peaje{
        public string vehículo;
        public int importe;
        public int horario;
        public string dia;
        public string pico;
    }

    static void Main(string[] args){

        bool continuar = true;

        Peaje cuota = new Peaje();
        
        Dictionary <string, int> importes = new Dictionary<string, int>(){
            {"moto", 5},
            {"auto", 10},
            {"camioneta", 15},
            {"camion", 20},
        };

        Dictionary<string, string> diasSemana = new Dictionary<string, string>(){
            {"1", "lunes"},
            {"2", "martes"},
            {"3", "miercoles"},
            {"4", "jueves"},
            {"5", "viernes"},
            {"6", "sabado"},
            {"7", "domingo"},
        };

        List<Peaje> peajes = new List<Peaje>();

       do
        {
            // ---------------------------------------------------------------------------------------------------- codigo que define el vehiculo y el precio base

            Console.WriteLine("escriba un vehiculo");
            cuota.vehículo = Console.ReadLine();
            int precio = importes[cuota.vehículo.ToLower()];

            int precioHoraPicoSemana = (int)(precio * 1.20);
            int precioDomingos = (int)(precio * 1.10);

            // ---------------------------------------------------------------------------------------------------- codigo que define el dia

            Console.WriteLine("escribe que dia de la semana es (del 1 al 7)");

            string diadeSemana = diasSemana[Console.ReadLine()];

            cuota.dia = diadeSemana;

            
            // ---------------------------------------------------------------------------------------------------- codigo que define si es hora pico

            Console.WriteLine("escribe la hora (solo la hora, sin minutos)");
            cuota.horario = int.Parse(Console.ReadLine());
        
            if ((cuota.horario >= 6 && cuota.horario <= 10) || (cuota.horario >= 17 && cuota.horario <= 19))
            {
                cuota.pico = "pico";
            }
            else
            {
                cuota.pico = "no pico";
            }

            // ---------------------------------------------------------------------------------------------------- codigo que pasa el importe 

            if (cuota.pico == "pico" && cuota.dia != "sabado" && cuota.dia != "domingo")
            {    
                cuota.importe = precioHoraPicoSemana;
            }
            else if ((cuota.pico == "no pico" && cuota.dia != "domingo") | (cuota.dia == "sabdo"))
            {
                cuota.importe = precio;
            }
            else if (cuota.dia == "domingo")
            {
            
                cuota.importe = precioDomingos;
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            // ---------------------------------------------------------------------------------------------------- codigo de vuelto
            Console.WriteLine("indique con cuanto pago");

            int pagoCliente = int.Parse(Console.ReadLine());

            int vuelto = pagoCliente - cuota.importe;

            Console.WriteLine($"Tiene que darle de vuelto {vuelto}");
            
            // --------------------------------------------------------------------------------------------------- añade a la lista


            peajes.Add(cuota);


            // ---------------------------------------------------------------------------------------------------- codigo que corta el do while

            Console.WriteLine("Quiere seguir cargando? si/no");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "no")
            {
                continuar = false;
            }


        } while (continuar);
        
        List<Peaje> objetosBuscados = peajes.FindAll(obj => obj.vehículo == "auto" && obj.pico == "pico");

           


        int TotalRecaudado = peajes.Sum(p => p.importe);
        int TotalPases = peajes.Count;
        int Buscados = objetosBuscados.Count;

        Console.WriteLine($"El total recaudado es de: ${TotalRecaudado}, El total de pases fue de: {TotalPases} y El total de autos que pasaron en hora pico fue de {Buscados}");

    }
}

/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                                                cambio de ejercicio

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


Se desea desarrollar un programa para registrar la información de cada uno de los distintos libros, que es la siguiente:

-----------------------------Título (cadena de 20 caracteres)------------------------------------------------------------------------------------------------------------------ 
-----------------------------Cantidad de unidades (valor entero mayor a cero)--------------------------------------------------------------------------------------------------
-----------------------------Precio por unidad (valor real)--------------------------------------------------------------------------------------------------------------------
-----------------------------Nacionalidad del autor (valor entero, 1=Americana, 2=Europea, 3=Africana, 4=Asiática o de Oceanía)------------------------------------------------
-----------------------------Marca que indica si es de ficción o no. (1 carácter, ‘S’=Es de ficción o ‘N’=No es de ficción)----------------------------------------------------


Luego de cada ingreso de información, el programa debe preguntarle al operador si desea seguir ingresando datos o no.

Se pide informar: 
a) Por cada libro, el monto del seguro que debe abonar el predio por exponerlo. El monto del seguro por cada libro se calcula como el 10% del precio unitario por la cantidad de unidades del libro. ------------------------------------------------------------------------------------------------------------------------------------------------------

b) Cantidad de libros de ficción por cada nacionalidad de autor. 

c) El precio por unidad máximo, en base al reporte de todos los libros, informando además el título del libro (se supone único). 

d) Cuál es el nivel de la exposición, considerando que puede ser Malo, Regular, Bueno o Muy bueno, si el acumulado total de unidades de los libros expuestos es menor que 5000, 10000, 20000 o 30000 respectivamente, Mostrar un cartel por pantalla que lo indique.------------------------------------------------------------------------------------------



class Program{
    
    struct Libros
    {
        public string titulo;
        public int cantidadLibros;
        public int precioPorUnidad;
        public string nacionalidadAutor;
        public string ficción;
        public int exposición;
        public string clasificacion;
    }

   

    static void Main(string[] args){

        bool continuar = true;

        Dictionary<string, string> Nacionalidad = new Dictionary<string, string>{
        {"1", "Americana"},
        {"2", "Europea"},
        {"3", "Africana"},
        {"4", "Asiática o de Oceanía"},
        };

        Dictionary<string, string> Ficcion = new Dictionary<string, string>{
            {"S", "Ficcion"},
            {"N", "No Ficcion"},
        };


        Libros libro = new Libros();

        List<Libros> libros = new List<Libros>();


    
        do
        {
            //--------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Escriba el titulo del libro");

            libro.titulo = Console.ReadLine();

            //--------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Escriba la cantidad de libros a exponer");

            libro.cantidadLibros = int.Parse(Console.ReadLine());

            

            //--------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Indique el precio por unidad");

            libro.precioPorUnidad = int.Parse(Console.ReadLine());

            //--------------------------------------------------------------------------------------------------------------------

            int montoSeguroUnitario = (int)(libro.precioPorUnidad * 0.10 );
            int montoSeguroTotal = (int)(montoSeguroUnitario * libro.cantidadLibros);

            //--------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Escriba la nacionalidad del autor (1=Americana, 2=Europea, 3=Africana, 4=Asiática o de Oceanía)");

            string nacionalidad = Nacionalidad[Console.ReadLine()];

            libro.nacionalidadAutor = nacionalidad;

            //--------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Es de ficcion? (S = Es de ficción o N = No es de ficción)");

           string letraFiccion = Console.ReadLine();
           
            string esFiccion = Ficcion[letraFiccion.ToUpper()];

            libro.ficción = esFiccion;

            //--------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Cual fue el nivel de exposicion del libro?");

            libro.exposición = int.Parse(Console.ReadLine());


            if (libro.exposición <= 5000)
            {

                libro.clasificacion = "malo";

            }else if (libro.exposición <= 10000 && libro.exposición > 5000 )
            {

                libro.clasificacion = "Regular";

            }else if (libro.exposición <= 20000  && libro.exposición > 10000)
            {

                libro.clasificacion = "Bueno";

            } else if (libro.exposición > 20000)
            {
                
                libro.clasificacion = "Muy Bueno";

            }

            libros.Add(libro);

            Console.WriteLine("desea seguir agragando? si/no");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "no")
            {
                continuar = false;
            }

        } while (continuar);
    
        int libroMasCaro = libros.Max(p => p.precioPorUnidad);
        


    }
}
*/

/*
Para ayudar a la maestra, se te pide que desarrolles una aplicación, que obtenga los siguientes resultados:

    -a) Por cada alumno, informar su nombre y su posición en la fila. Al finalizar.  ********************************
    
informar: 

    -b) La cantidad de alumnos en la fila, de cada curso. ********************************
    -c) La altura del alumno más alto y la del más bajo (se suponen únicos), indicando en ambos casos, su posición en la fila. Considerar sólo a los alumnos de quinto grado. ********************************
    -d) El promedio de las alturas, considerando a los alumnos de todos los grados.********************************

De cada alumno se conoce la siguiente información: 
    -Nombre (valor cadena).  ********************************
    -Altura en cm (valor entero).  ********************************
    -Grado (valor entero de 1 a 5).  ********************************
    -Curso al que pertenece (valor char: ‘A’, ‘B’ o ‘C’). ********************************


class Program{

    struct Alumnos{
        public string nombre;    
        public int  grados;
        public int  altura;
        public char curso;
   
    }

  
    static void Main(string[] args){
        
        bool continuar = true;

        List<Alumnos> alumnos = new List<Alumnos>();
            
        Alumnos alumno = new Alumnos();

        do
        {

            Console.WriteLine("Escribe el del alumno");

            alumno.nombre = Console.ReadLine();

            Console.WriteLine("Escribe el grado del alumno (A, B o C)");

            alumno.grados = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe la altura del alumno (en cm)");

            alumno.altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el curso del alumno");

            alumno.curso = char.Parse(Console.ReadLine());


            alumnos.Add(alumno); 


            Console.WriteLine("Desea continuar? si/no");

            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "no")
            {
                continuar = false;
            }

        } while (continuar);




        // -a) Por cada alumno, informar su nombre y su posición en la fila. Al finalizar.  ********************************
        foreach (Alumnos alumnos1 in alumnos)
        {
            int posicion = alumnos.IndexOf(alumno);
            Console.WriteLine($"nombre: {alumno.nombre}, grado: {alumno.grados}, curso: {alumno.curso}, altura: {alumno.altura}, posicion: {posicion}");
        }

        // -b) La cantidad de alumnos en la fila, de cada curso. ********************************

        List<Alumnos> alumnosCursoC = alumnos.Where(estudiante => alumno.curso == 'C').ToList();
        List<Alumnos> alumnosCursoB = alumnos.Where(estudiante => alumno.curso == 'B').ToList();
        List<Alumnos> alumnosCursoA = alumnos.Where(estudiante => alumno.curso == 'A').ToList();


        int CantidadporCursoC  =  alumnosCursoC.Count();
        int CantidadporCursoB  =  alumnosCursoB.Count();
        int CantidadporCursoA  =  alumnosCursoA.Count();

        Console.WriteLine($"La cantidad de alumnos en el curso A es de {CantidadporCursoA}, La cantidad de alumnos en el curso B es de {CantidadporCursoB}, La cantidad de alumnos en el curso C es de {CantidadporCursoC}");


        //  -c) La altura del alumno más alto y la del más bajo (se suponen únicos), indicando en ambos casos, su posición en la fila. Considerar sólo a los alumnos de quinto grado. ********************************

        List<Alumnos> alumnos5grado = alumnos.Where(estudiantes => alumno.grados == 5).ToList();

        int alumnoMasAlto = alumnos5grado.Max(estudiante => alumno.altura);
        int alumnoMasBajo = alumnos5grado.Min(estudiante => alumno.altura);

        int posicionAlumnoMasAlto = alumnos.FindIndex(estudiante => alumno.altura == alumnoMasAlto);
        int posicionAlumnoMasBajo = alumnos.FindIndex(estudiante => alumno.altura == alumnoMasBajo);

        Console.WriteLine($" el alumno mas alto mide: {alumnoMasAlto}cm y su posicion en la fila es {posicionAlumnoMasAlto}, El alumno mas bajo mide: {alumnoMasBajo}cm y su posicion en la fila es {posicionAlumnoMasBajo}");


        //  -d) El promedio de las alturas, considerando a los alumnos de todos los grados.********************************
        int CantidadTotalAlumnos = alumnos.Count();

        int sumaAlturas = alumnos.Sum(estudiantes => alumno.altura);

        int promedioAltura = (int)(sumaAlturas / CantidadTotalAlumnos);

        Console.WriteLine($"La altura promedio es de {promedioAltura}");

    }
}
*/


/*
La aplicación permitirá al mecánico registrar las intervenciones realizadas sobre cada vehículo, y en función de ello calculará el importe que deberá pagar el usuario.

Por cada vehículo atendido se debe ingresar:

• Patente.
• Kilometraje.
• Antigüedad en meses desde la adquisición.
• El Service siempre incluye el cambio de aceite y los filtros. Pero adicionalmente, el mecánico debe registrar si se realizó o no c/u de los siguientes trabajos:
    a. Regulación de válvulas.
    b. Regulación de frenos.
    c. Regulación de cadena.
    d. Cambio de repuestos adicionales: en caso de ser sí, también deberá ingresar el valor total de los repuestos.


El valor del Service para cada vehículo en garantía es de $ 800. Ese importe incluye cualquier trabajo y repuesto cambiado.

El valor del Service para cada vehículo fuera de garantía es de $ 1.000, lo que incluye solamente el trabajo de cambio de aceite y los filtros. Por cada trabajo adicional se debe sumar a ese importe lo siguiente:

    a. Regulación de válvula: $ 1000.
    b. Regulación de frenos: $500.
    c. Regulación de cadena: $200.
    d. Cambio de repuestos adicionales: el valor ingresado para los repuestos.

Para que un vehículo esté en garantía debe tener menos de 20.000 KM y menos de 12 meses desde la adquisición. ********************************************************

Informar:
por lista
    • Por cada vehículo atendido el valor del Service. ***********************
    • El total de vehículos atendidos, diferenciando cuantos están en garantía y cuantos no. *******************************
    • El total de facturación.
    • El total de vehículos a los que se les regularon válvulas.
    • El valor del servicio más caro.

Se ingresan vehículos hasta que el mecánico lo desee.




class Program{

    struct Vehiculo
    {
        public string Patente;
        public int Kilometraje;
        public int antiguedad;
        public string trabajo;
        public string garantía;
        public int factura;
    }



    static void Main(string[] args){

        Dictionary<string, int> Precios = new Dictionary<string, int>{
        {"regulación de válvula",  1000},
        {"regulación de frenos", 500},
        {"regulación de cadena", 200},
        };

        Vehiculo coche = new Vehiculo();
        bool garantía = false;
        bool continuar = true;

        int precioApagar;

        List<Vehiculo> vehiculos = new List<Vehiculo>();
        
        do
        {
            //----------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Escriba la patente del vehiculo");

            coche.Patente = Console.ReadLine();

            Console.WriteLine("Escriba el kilometraje del vehiculo (en KM)");

            coche.Kilometraje = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba la antiguedad del vehiculo (en meses)");

            coche.antiguedad = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el trabajo  que se le realixo al vehiculo");

            coche.trabajo = Console.ReadLine();



            // Para que un vehículo esté en garantía debe tener menos de 20.000 KM y menos de 12 meses desde la adquisición.

            if (coche.Kilometraje < 20000 && coche.antiguedad <= 12)
            {
                garantía = true;
                coche.garantía = "posee garantia";
            }else{
                coche.garantía = "no posee garantia";
            }



            if (garantía == true)
            {
                // El valor del Service para cada vehículo en garantía es de $ 800. Ese importe incluye cualquier trabajo y repuesto cambiado.
                precioApagar = 800;
                coche.factura = precioApagar;
            }else
            {
                // El valor del Service para cada vehículo fuera de garantía es de $ 1.000, lo que incluye solamente el trabajo de cambio de aceite y los filtros. Por cada trabajo adicional se debe sumar a ese importe

                int precioServicio =  Precios[coche.trabajo.ToLower()];

                precioApagar = 1000 + precioServicio;

                coche.factura = precioApagar;

                Console.WriteLine($"El costo total del servicio es {precioApagar}");
            }

            vehiculos.Add(coche);

            // Se ingresan vehículos hasta que el mecánico lo desee.

            Console.WriteLine("Quiere continuar agregando? si/no");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "no")
            {
                continuar = false;
            }

            
        } while (continuar);

       
       
        foreach (Vehiculo vehiculo in vehiculos)
        {
            Console.WriteLine($"La patente es: {coche.Patente}, La entiguedad es de: {coche.antiguedad} meses, El kilometraje es de: {coche.Kilometraje}, La garanti del vehuculo: {coche.garantía}, {coche.trabajo}, {coche.factura}");
        }

        int vehiculosGarantia = vehiculos.Count(p => p.garantía == "posee garantia");
        Console.WriteLine($"la catidad de autos en garantia es de {vehiculosGarantia}");

        int facturaTotal = vehiculos.Sum(p => p.factura);

        List<Vehiculo> vehiculosValvulas = vehiculos.Where(elemento => coche.trabajo == "regulación de válvula").ToList();
        int totalValvulas = vehiculosValvulas.Count();

        Console.WriteLine($"La cantidad de vehiculos que les regularon las valvulas fue de {totalValvulas}");

        int servicioCaro = vehiculos.Max(p => p.factura);
        Console.WriteLine($"La factura de mayor costo fue de: ${servicioCaro}");
    }
}

 */

 /*
    Realizar un algoritmo en diagrama de flujo que permita el ingreso del Nombre, Sexo, Sueldo Bruto y la cantidad de hijos de 30 empleados y a continuación
    informe:
    1. ////Para cada empleado el sueldo bruto, el descuento (tomar 15% del sueldo bruto), las asignaciones familiares y el sueldo neto (sueldo bruto - descuento + asignaciones familiares). 

    2. Cuantos empleados no cobran asignaciòn por hijos.
    3. Cuanto es el monto total que retiene la empresa a los empleados en concepto de descuento.
    4. Promedio de Sueldos.
    5. Porcentaje de hombres.

    LAS ASIGNACIONES FAMILIARES SOLO SE APLICAN A LAS MUJERES. CONDICIONES PARA CONSIDERAR LAS ASIGNACIONES FAMILIARES (SUELDO ENTRE):
    - /////100,00 y 2800,00 $ 270 x hijo
    - ////2800,01 y 4000,00 $204 /x hijo
    - ////4000,01 y 5200,00 $ 136 x hijo
    - ////Más de 5200 No cobra
 
 class Program{
    struct Trabajador
    {
        public int sueldo; ////
        public int sueldoBruto; ////
        public int asignaciones; ////
        public bool sexo; ////
        public int descuento; ////
        public int cantHijos; ////
    }


    static void Main(string[] args){

        List<Trabajador> trabajadores = new List<Trabajador>();

        Trabajador empleado = new Trabajador();


        for (int i = 0; i <= 30; i++)
        {
            
            Console.WriteLine("Que sexo es? f/m");
            
            string sexoEmpleado = Console.ReadLine();
            if (sexoEmpleado.ToLower() == "f")
            {
                empleado.sexo = true;
            }
            
            Console.WriteLine("Escriba la cantidad de hijos que tiene");
            
            empleado.cantHijos = int.Parse( Console.ReadLine());

            

           //--------------------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Escriba cuanto cobra por mes");
            
            empleado.sueldoBruto = int.Parse(Console.ReadLine());

            if ((sexoEmpleado.ToLower() == "f") && ( empleado.sueldo >= 100 && empleado.sueldo < 2800))
            {
                
                int calculoAsignacion = 270 * empleado.cantHijos;
                empleado.asignaciones = calculoAsignacion;
                int descuento = (int)(empleado.sueldoBruto * 0.15);
                empleado.descuento = descuento;

                empleado.sueldo = empleado.sueldoBruto - descuento + calculoAsignacion;

            }else if ((sexoEmpleado.ToLower() == "f") && ( empleado.sueldo >= 2800 && empleado.sueldo < 4000))
            {
                
                int calculoAsignacion = 204 * empleado.cantHijos;
                empleado.asignaciones = calculoAsignacion;
                int descuento = (int)(empleado.sueldoBruto * 0.15);
                empleado.descuento = descuento;

                empleado.sueldo = empleado.sueldoBruto - descuento + calculoAsignacion;

            }else if ((sexoEmpleado.ToLower() == "f") && ( empleado.sueldo >= 4000 && empleado.sueldo < 5200))
            {
                
                int calculoAsignacion = 136 * empleado.cantHijos;
                empleado.asignaciones = calculoAsignacion;
                int descuento = (int)(empleado.sueldoBruto * 0.15);
                empleado.descuento = descuento;

                empleado.sueldo = empleado.sueldoBruto - descuento + calculoAsignacion;

            }else if ((sexoEmpleado.ToLower() == "f") && ( empleado.sueldo >= 5200))
            {
                empleado.asignaciones = 0;
                int descuento = (int)(empleado.sueldoBruto * 0.15);
                empleado.descuento = descuento;

                empleado.sueldo = empleado.sueldoBruto - descuento;                

            }else
            {
                Console.WriteLine("ERROR!!!!!!!!!!!!");
            }

            trabajadores.Add(empleado);
        }

                                                                                /*
                                                                                    2. ////Cuantos empleados no cobran asignaciòn por hijos.
                                                                                    3. ////Cuanto es el monto total que retiene la empresa a los empleados en concepto de descuento.
                                                                                    4. ////Promedio de Sueldos.
                                                                                    5. ////Porcentaje de hombres.
                                                                                


        List <Trabajador> trabajadoresSinAsignacion = trabajadores.FindAll(p => ((p.sexo == true ) && (p.cantHijos < 1)) | (p.sexo == false));

        int cantTrabajadoresSinAsignacion = trabajadoresSinAsignacion.Count();

        Console.WriteLine($"La cant de trabajadpres sin asignacion es de: {cantTrabajadoresSinAsignacion}");

        int totalDescontado = trabajadores.Sum(p => p.descuento);
        Console.WriteLine($"El monto total descontado es de {totalDescontado}");

        int totalSueldos = trabajadores.Sum(p => p.sueldo);
        int promedioSueldos = totalSueldos / 30;

        Console.WriteLine($"El promedio de los sueldos es de: ${promedioSueldos}");

        List <Trabajador> trabajadoresH = trabajadores.FindAll(p => p.sexo == false);
        int cantTrabajadoresH = trabajadoresH.Count();

        int calculoPorcentual = (cantTrabajadoresH * 100) / 30;

        Console.WriteLine($"El porcentaje de hombres es de {calculoPorcentual}%");

    }
 } */

 /*
 15-DADA UNA COMPRA DE 30 PC PARA UNA EMPRESA Y SABIENDO QUE CADA UNA CUESTA 11500 PESOS.
    -SÉ QUE EL PROVEEDOR ME HACE UN 20% DE DESCUENTO.
    -SÉ QUE EL ENVÍO ME COBRA UN 5% DEL TOTAL.
    -SÉ QUE EL SEGURO DE TRASLADO ES 12% DEL TOTAL EL CUAL SE DEVUELVEN SI LOS EQUIPOS LLEGAN BIEN.
    ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    -////OBTENER EL PRECIO SIN DESCUENTOS. 
    -////EL PRECIO CON TODOS LOS DESCUENTOS SI TODAS LAS PC LLEGAN BIEN. 
    -////EL PRECIO CON TODOS LOS DESCUENTOS SI LAS PC LLEGAN MAL. 
    -////SOLAMENTE EL PRECIO DEL DESCUENTO 
    -////SOLAMENTE EL PRECIO DEL ENVÍO.
 

 class Program
{
    public static int precioPc = 11500;
    public static int cantPc = 30;
    public static double porcenProveedor = 0.20;
    public static double porcenEnvio = 0.05;
    public static double porcenSeg = 0.12;

    static void Main(string[] args)
    {
        Precios();
    }

    public static void Precios()
    {
        int precioTotal = precioPc * cantPc;
        Console.WriteLine($"{precioTotal}");

        double descuentoSeg = precioTotal * porcenSeg;
        double descuentoProv = precioTotal * porcenProveedor;
        double descuentoEnv = precioTotal * porcenEnvio;

        double precioApagarConDes = (precioTotal - descuentoProv);
        Console.WriteLine($"{precioApagarConDes}");

        double precioPcMal = ((precioTotal - descuentoEnv) - descuentoProv) - descuentoSeg;
        Console.WriteLine($"{precioPcMal}");

        double precioDescuentos = descuentoEnv + descuentoProv + descuentoSeg;
        Console.WriteLine($"{precioDescuentos}");

        Console.WriteLine($"{descuentoEnv}");
    }
}
*/

/*Programa un juego de adivinanza de números. El programa debe generar un número aleatorio entre 1 y 100 y pedir al usuario que adivine el número. El programa debe indicar si el número ingresado es mayor o menor que el número aleatorio y permitir al usuario seguir intentando hasta que adivine el número correcto.

class Program{
    static void Main(string[] args){

        Game();

    }


    static void Game(){

        bool continuar = true;

        do
        {
            Random numRam = new Random();

            int randomNum = numRam.Next(1, 101);

            bool acierto = true;
            do
            {
                
                Console.WriteLine("Adivine el numero aleatorio");
                int numeroUsuario = int.Parse(Console.ReadLine());

                if (numeroUsuario != randomNum && numeroUsuario < randomNum)
                {

                    Console.WriteLine($"Vuelve a intentar, {numeroUsuario} es mas chico");

                } else if (numeroUsuario != randomNum && numeroUsuario > randomNum)
                {

                    Console.WriteLine($"Vuelve a intentar, {numeroUsuario} es mas grande");

                } else if (numeroUsuario == randomNum)
                {
                    
                    Console.WriteLine($"Lo adivinaste, el numero era {numeroUsuario}");
                    acierto = false;

                }else
                {
                    Console.WriteLine("ERROR");
                    acierto = false;
                }


            } while (acierto);
            
            Console.WriteLine("Desea seguir juagando? si/no");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "no")
            {
                continuar = false;
            }

        } while (continuar);
        
    }
}

//Escribe un programa que lea una lista de números enteros del usuario y muestre la suma, el promedio, el valor máximo y el valor mínimo.

class Program{

   

    static void Main(string[] args){
        secuencia();
    }



    static void secuencia(){

        List <int> numeros = new List<int>();

        Console.WriteLine("Escriba una seguidilla de numeros");
        string input = Console.ReadLine();

        string[] numerosComoCadena = input.Split(',');

        foreach (string numeroComoCadena in numerosComoCadena)
        {
            int numero;

            if (int.TryParse(numeroComoCadena.Trim(), out numero))
            {
                numeros.Add(numero);
            }
        } 

        int suma = numeros.Sum();
        int cantidadNumeros = numeros.Count();

        double promedio = suma / cantidadNumeros;

        int maximo = numeros.Max();
        int minimo = numeros.Min();

        Console.WriteLine($"la suma total es de {suma}, el proemdio es de {promedio}, el valor mx es de {maximo}, el valor minimo  es de {minimo}");

    } 
}

//Crea una clase "Rectángulo" con propiedades para el ancho y la altura. Añade métodos para calcular el área y el perímetro del rectángulo.

class Program{
    
    struct Rectangulos
    {
        public int ancho;
        public int altura;
        public int area;
        public int perimetro;
    }

    static void Main(string[] args){

    }


    static void rectangulo (){
        Rectangulos rectangulos = new Rectangulos();
        Console.WriteLine("escriba el ancho del rectangulo");
        rectangulos.ancho = int.Parse(Console.ReadLine());
        Console.WriteLine("escriba la altura del rectangulo");
        rectangulos.altura = int.Parse(Console.ReadLine());

        int area = rectangulos.altura * rectangulos.ancho;
        rectangulos.area = area;

        int perimetro = (2 * rectangulos.altura) + (2 * rectangulos.ancho);
        rectangulos.perimetro = perimetro;

    }
}


//Escribe un programa que convierta una cantidad de dólares a euros. El programa debe solicitar al usuario la cantidad de dólares y mostrar la cantidad equivalente en euros.

class Program{
    static void Main(){
        Convertidor();
    }

    static void Convertidor(){
        double precioEuroXDolar = 1.25;
        double dolares;

        Console.WriteLine("Cuantos dolares quiere convertir");

        dolares = double.Parse(Console.ReadLine());

        double cantidadConvertida = dolares / precioEuroXDolar;

        Console.WriteLine($"la cantidad de euros es de {cantidadConvertida}");

    }
}
*/

//Crea un programa que permita al usuario crear una lista de tareas. El programa debe permitir al usuario agregar, eliminar y completar tareas, así como mostrar una lista de todas las tareas pendientes.



class Program{
    struct Tarea{
        public string nombre;
        public int duracion;
        public bool completa;
        public string asignado;
    }

    struct Persona {
        public string nombre;
        public int edad;
        public string rol;
        public bool habilitado; 
        public int id;
    }

 
    
    static void Main(){

    }

    public class Tareas{

        static private JObject baseTareas = new JObject();

        public JObject CrearTarea(){

            Tarea resposabilidad = new Tarea();

            Console.WriteLine("Escriba la tarea");
            resposabilidad.nombre = Console.ReadLine();

            Console.WriteLine("Esriba la duracion de la tarea en minutos");
            resposabilidad.duracion = int.Parse(Console.ReadLine());
            

            resposabilidad.completa = false;

            Console.WriteLine("Escriba a quien se le asigna la tarea");
            resposabilidad.asignado = Console.ReadLine();


            baseTareas.Add("tareas", JToken.FromObject(resposabilidad));

            return baseTareas;

        }

        public void EliminarTarea(){
            JObject baseTareas = CrearTarea();

            Console.WriteLine("Escriba el nombre de la tarea que desea eliminar");
            string nombreEliminar = Console.ReadLine();

            JToken tareaELiminar = baseTareas.SelectToken($"$.tareas[?(@.nombre == '{nombreEliminar}')]");

            if (tareaELiminar != null)
            {
                tareaELiminar.Remove();
                Console.WriteLine("Se a eliminado la tarea");
            }else
            {
                Console.WriteLine("Error, no se ah encontrado la tarea");
            }
            
        }

        public void EditarTarea(){

            JObject baseTarea = CrearTarea();

            Console.WriteLine("Escriba el nombre de la tarea que busca editar");
            string tareaEditar = Console.ReadLine();

            if (baseTarea.ContainsKey(tareaEditar))
            {
                Console.WriteLine("Que desea editar");
                string valorEditar = Console.ReadLine();
                if (valorEditar.ToLower() != "duracion")
                {
                    Console.WriteLine("Escriba el nuevo valor");
                    string nuevoValor = Console.ReadLine();

                    JToken tareaToken = baseTarea[tareaEditar];
                    tareaToken[valorEditar] = nuevoValor;

                }else
                {
                    Console.WriteLine("Escriba el nuevo valor");
                    int nuevoValor = int.Parse(Console.ReadLine());

                    JToken tareaToken = baseTarea[tareaEditar];
                    tareaToken[valorEditar] = nuevoValor;
                }

            }else
            {
                Console.WriteLine("Error tarea no encontrada");
            }
        }
    }

    

    static void CrearUsuario(){
        


        Persona usuario = new Persona(); 
        JObject DataBase = new JObject();

        Console.WriteLine("Escriba su nombre");

        usuario.nombre = Console.ReadLine(); 

        Console.WriteLine("Escriba su edad");

        usuario.edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Escriba su rol (madre / padre / hijo)");

        usuario.rol = Console.ReadLine();

        

        if ((usuario.rol.ToLower() == "madre") | (usuario.rol.ToLower() == "padre"))
        {
            usuario.habilitado = true;

            Tareas responsabilidades = new Tareas();
            
        }else if (usuario.rol.ToLower() == "hijo")
        {
            usuario.habilitado = false;
        } else
        {
            usuario.habilitado = false;
            Console.WriteLine("ERROR");
        }

        



        Guid guid = new Guid();
        string idAleatorio = guid.ToString();
        usuario.id = int.Parse(idAleatorio);



        JObject objetoJson = JObject.Parse(DataBase.ToString());

        JToken encontrar = objetoJson.SelectToken($"$.usuario[?(@.id == {idAleatorio})]");

        if (encontrar != null)
        {
            Console.WriteLine("ERROR");
        }else
        {
            int idIdentificado = encontrar.Value<int>("id");
            Console.WriteLine($"el id es {idIdentificado}");
        }
        
        DataBase.Add("usuario", JToken.FromObject(usuario));
    }

}



