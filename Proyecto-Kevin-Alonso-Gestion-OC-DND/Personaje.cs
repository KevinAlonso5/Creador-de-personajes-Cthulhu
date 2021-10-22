using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Proyecto_Kevin_Alonso_Gestion_OC_DND
{
    public class Personaje
    {
        public String nombre;
        public String trabajo;
        public String jugador;
        public int edad;

        public int fuerza;
        public int destreza;
        public int poder;
        public int contitucion;
        public int apariencia;
        public int educacion;
        public int tamaño;
        public int inteligencia;

        public Habilidades habilidades;

        public Armas armas;

        public Personaje (string nombre, string trabajo, String jugador, int edad, int fuerza,
            int destreza, int poder, int constitucion, int apariencia,
            int educacion, int tamaño, int inteligencia, Habilidades habilidades)
        {
            this.nombre = nombre;
            this.trabajo = trabajo;
            this.jugador = jugador;
            this.edad = edad;

            this.fuerza = fuerza;
            this.destreza = destreza;
            this.poder = poder;
            this.contitucion = constitucion;
            this.apariencia = apariencia;
            this.educacion = educacion;
            this.tamaño = tamaño;
            this.inteligencia = inteligencia;

            this.habilidades = habilidades;

            //this.armas = armas;
    }
    }

    public class Habilidades
    {
        public int antropologuia;
        public int armaCorta;
        public int armaLarga;
        public int arqueologuia;
        public int arte;
        public int buscarLibros;
        public int cerrajeria;
        public int charlataneria;
        public int ciencia;
        public int cienciasOcultas;
        public int combate;
        public int conducirCoche;
        public int conducirMaquina;
        public int contavilidad;
        public int credito;
        public int derecho;
        public int descubrir;
        public int disfrazarse;
        public int electricidad;
        public int encanto;
        public int equitacion;
        public int escuchar;
        public int esquivar;
        public int historia;
        public int intimidar;
        public int juegoManos;
        public int lanzar;
        public int mecanica;
        public int medicina;
        public int mitosCthulhu;
        public int nadar;
        public int naturaleza;
        public int orientarse;
        public int persuasion;
        public int pilotar;
        public int primerosAux;
        public int psicoanalisis;
        public int psicologuia;
        public int saltar;
        public int seguirRastro;
        public int siguilo;
        public int supervivencia;
        public int tasacion;
        public int trepar;

        public Habilidades ( int antropologuia, int armaCorta, int armaLarga,
         int arqueologuia, int arte, int buscarLibros, int cerrajeria, int charlataneria,
         int ciencia, int cienciasOcultas, int combate, int conducirCoche, int conducirMaquina,
         int contavilidad, int credito, int derecho, int descubrir, int disfrazarse,
         int electricidad, int encanto, int equitacion, int escuchar, int esquivar,
         int historia, int intimidar, int juegoManos, int lanzar, int mecanica, int medicina,
         int mitosCthulhu, int nadar, int naturaleza, int orientarse, int persuasion, int pilotar,
         int primerosAux, int psicoanalisis, int psicologuia, int saltar, int seguirRastro,
         int siguilo, int supervivencia, int tasacion, int trepar)
        {
            this.antropologuia = antropologuia;
            this.armaCorta = armaCorta;
            this.armaLarga = armaLarga;
            this.arqueologuia = arqueologuia;
            this.arte = arte;
            this.buscarLibros = buscarLibros;
            this.cerrajeria = cerrajeria;
            this.charlataneria = charlataneria;
            this.ciencia = ciencia;
            this.cienciasOcultas = cienciasOcultas;
            this.combate = combate;
            this.conducirCoche = conducirCoche;
            this.conducirMaquina = conducirMaquina;
            this.contavilidad = contavilidad;
            this.credito = credito;
            this.derecho = derecho;
            this.descubrir = descubrir;
            this.disfrazarse = disfrazarse;
            this.electricidad = electricidad;
            this.encanto = encanto;
            this.equitacion = equitacion;
            this.escuchar = escuchar;
            this.esquivar = esquivar;
            this.historia = historia;
            this.intimidar = intimidar;
            this.juegoManos = juegoManos;
            this.lanzar = lanzar;
            this.mecanica = mecanica;
            this.medicina = medicina;
            this.mitosCthulhu = mitosCthulhu;
            this.nadar = nadar;
            this.naturaleza = naturaleza;
            this.orientarse = orientarse;
            this.persuasion = persuasion;
            this.pilotar = pilotar;
            this.primerosAux = primerosAux;
            this.psicoanalisis = psicoanalisis;
            this.psicologuia = psicologuia;
            this.saltar = saltar;
            this.seguirRastro = seguirRastro;
            this.siguilo = siguilo;
            this.supervivencia = supervivencia;
            this.tasacion = tasacion;
            this.trepar = trepar;
        }
    }

    public class Armas
    {
        public String nombre;
        public String daño;
        public String alcance;
        public String numAtaques;
        public String municion;
        public String averia;
        public int cortoLargo;

        public Armas (string nombre, string daño, string alcance,
            string numAtaques, string municion, string averia, int cortoLargo)
        {
            this.nombre = nombre;
            this.daño = daño;
            this.alcance = alcance;
            this.numAtaques = numAtaques;
            this.municion = municion;
            this.averia = averia;
            this.cortoLargo = cortoLargo;
        }
    }

    public class Basededatos<T>
    {
        List<T> valores = new List<T>();
        public string ruta;

        public Basededatos(string r)
        {
            ruta = r;
        }

        public void guardar()
        {
            string texto = JsonConvert.SerializeObject(valores);
            File.WriteAllText(ruta, texto);
        }

        public void cargar()
        {
            try
            {
                string archivo = File.ReadAllText(ruta);
                archivo = archivo+ lineasAnteriores();
                valores = JsonConvert.DeserializeObject<List<T>>(archivo);
            }
            catch (Exception) { }
        }

        public List<T> lineasAnteriores()
        {
            try
            {
                string archivo = File.ReadAllText(ruta);
                archivo = archivo + lineasAnteriores();
                List<T> salida = JsonConvert.DeserializeObject<List<T>>(archivo);
                return salida;
            }
            catch (Exception) { return null; }
        }

        public void insertar(T nuevo)
        {
            valores.Add(nuevo);
            guardar();
        }

        public List<T> buscar(Func<T, bool> criterio)
        {
            return valores.Where(criterio).ToList();
        }

        public void eliminar(Func<T, bool> criterio)
        {
            valores = valores.Where(x => !criterio(x)).ToList();
        }

        public void actualizar(Func<T, bool> criterio, T nuevo)
        {
            valores = valores.Select(x =>
            {
                if (criterio(x)) x = nuevo;
                return x;
            }).ToList();
        }
    }
}
