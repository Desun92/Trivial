using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivial
{
    public partial class FrmTrivial : Form
    {

        string[] listaPaises = {"España","Grecia","Alemania","Italia","Japón","Argentina","Bélgica","Brasil","Camerún","Canadá","Chile","Colombia","Corea del Norte","Corea del Sur","Cuba","Ecuador","Egipto","Eslovaquia","Finlandia","Hungría","India","Irlanda","Letonia","Marruecos","Mónaco","Perú","Portugal","Reino Unido","Rusia","Suecia","Turquia","Venezuela"};
        string[] listaCapitales = { "Madrid", "Atenas", "Berlín", "Roma","Tokio","Buenos Aires","Bruselas","Brasilia","Yaundé","Ottawa","Santiago","Bogotá","Pionyang","Seúl","La Habana","Quito","El Cairo","Bratislava","Helsinki","Budapest","Nueva Dheli","Dublín","Riga","Rabat","Mónaco","Lima","Lisboa","Londres","Moscú","Estocolmo","Ankara","Caracas"};
        Random azar = new Random();
        int pais; //Selecciona un pais al azar y en consecuencia la respuesta correcta
        int posRespuestaCorrecta; //Selecciona la posicion de la respuesta correcta
        int posRespuestaIncorrectaUno; //Selecciona la posicion de la primera respuesta incorrecta
        int posRespuestaIncorrectaDos; //Selecciona la posicion de la segunda respuesta incorrecta
        int posRespuestaIncorrectaTres; //Seleciona la posicion de la tercera respuesta incorrecta
        int respuestaIncorrectaUno; //Selecciona la primera respuesta incorrecta, para que no se repitan.
        int respuestaIncorrectaDos; //Selecciona la segunda respuesta incorrecta, para que no se repitan.
        int respuestaIncorrectaTres; //Selecciona la tercera respuesta incorrecta, para que no se repitan.
        int numPreguntas = 0; //Variable que controla el número de preguntas hasta el momento
        int preguntasAcertadas = 0; //Variable que controla el número de preguntas acertadas
        double acertadasPorcentaje; //Variable que acumulará el tanto por ciento de preguntas acertadas
        bool botonSiguiente = false; //Variable que controla que no podamos saltar la pregunta hasta responderla
        bool modoCapitales = false; //Variable que cambia el juego de preguntar países a preguntar capitales
        bool reinicioModo = false; //Variable que reinicializa el contador de preguntas acertadas y totales al cambiar de modo
        bool modoOpciones = true; //Variable que controla el modo de juego de varias opciones
        bool modoRespuesta = false; //Variable que controla el modo de juego en escribir respuesta

        public FrmTrivial()
        {
            //Primero seleccionamos un pais al azar de nuestro array entre los posibles valores. A continuacion elegimos una posicion de respuesta correcta entre las 4 posibles (variable posRespuestaCorrecta).

            InitializeComponent();
            pais = azar.Next(listaPaises.Length-1);
            posRespuestaCorrecta = azar.Next(4);
            TxtPais.Text = listaPaises[pais]; //Mostramos por pantalla el pais que ha tocado

            //En funcion de la posicion que nos haya tocado de la respuesta correcta, mostramos la capital asociada al pais que sea respuesta correcta en dicha posicion.

            switch(posRespuestaCorrecta)
            {
                case 0:
                    TxtRespuestaCero.Text = listaCapitales[pais];
                    break;
                case 1:
                    TxtRespuestaUno.Text = listaCapitales[pais];
                    break;
                case 2:
                    TxtRespuestaDos.Text = listaCapitales[pais];
                    break;
                default:
                    TxtRespuestaTres.Text = listaCapitales[pais];
                    break;
            }

            //Ahora generamos respuestas incorrectas que no coincidan con la respuesta correcta ni con el resto de respuestas incorrectas

            do
            {
                respuestaIncorrectaUno = azar.Next(listaPaises.Length - 1);  //Hasta que no generemos una respuesta errónea, lo seguimos haciendo.
            } while (respuestaIncorrectaUno == pais);

            do
            {
                respuestaIncorrectaDos = azar.Next(listaPaises.Length - 1);
            } while (respuestaIncorrectaDos == respuestaIncorrectaUno || respuestaIncorrectaDos == pais); //Generamos una respuesta errónea distinta de la anterior y distinta de la correcta

            do
            {
                respuestaIncorrectaTres = azar.Next(listaPaises.Length - 1);
            } while (respuestaIncorrectaTres == respuestaIncorrectaUno || respuestaIncorrectaTres == respuestaIncorrectaDos || respuestaIncorrectaTres == pais); //Lo mismo que la anterior

            //Ahora generaremos 3 posiciones para las respuestas incorrectas, que no pueden coincidir con la posicion en la que está la respuesta correcta, para ello lo haremos con el mismo método que usamos para generar respuestas incorrectas

            do
            {
                posRespuestaIncorrectaUno = azar.Next(4);
            } while (posRespuestaIncorrectaUno == posRespuestaCorrecta);

            do
            {
                posRespuestaIncorrectaDos = azar.Next(4);
            } while (posRespuestaIncorrectaDos == posRespuestaCorrecta || posRespuestaIncorrectaDos == posRespuestaIncorrectaUno);

            do
            {
                posRespuestaIncorrectaTres = azar.Next(4);
            } while (posRespuestaIncorrectaTres == posRespuestaCorrecta || posRespuestaIncorrectaTres == posRespuestaIncorrectaUno || posRespuestaIncorrectaTres == posRespuestaIncorrectaDos);

            //Una vez tenemos las 3 posiciones, haremos un switch en función de su valor para asignarlas a los huecos que correspondan, y lo haremos respuesta por respuesta

            switch (posRespuestaIncorrectaUno)
            {
                case 0:
                    TxtRespuestaCero.Text = listaCapitales[respuestaIncorrectaUno];
                    break;
                case 1:
                    TxtRespuestaUno.Text = listaCapitales[respuestaIncorrectaUno];
                    break;
                case 2:
                    TxtRespuestaDos.Text = listaCapitales[respuestaIncorrectaUno];
                    break;
                default:
                    TxtRespuestaTres.Text = listaCapitales[respuestaIncorrectaUno];
                    break;
            }

            switch (posRespuestaIncorrectaDos)
            {
                case 0:
                    TxtRespuestaCero.Text = listaCapitales[respuestaIncorrectaDos];
                    break;
                case 1:
                    TxtRespuestaUno.Text = listaCapitales[respuestaIncorrectaDos];
                    break;
                case 2:
                    TxtRespuestaDos.Text = listaCapitales[respuestaIncorrectaDos];
                    break;
                default:
                    TxtRespuestaTres.Text = listaCapitales[respuestaIncorrectaDos];
                    break;
            }

            switch (posRespuestaIncorrectaTres)
            {
                case 0:
                    TxtRespuestaCero.Text = listaCapitales[respuestaIncorrectaTres];
                    break;
                case 1:
                    TxtRespuestaUno.Text = listaCapitales[respuestaIncorrectaTres];
                    break;
                case 2:
                    TxtRespuestaDos.Text = listaCapitales[respuestaIncorrectaTres];
                    break;
                default:
                    TxtRespuestaTres.Text = listaCapitales[respuestaIncorrectaTres];
                    break;
            }
        }

        private void FrmTrivial_Load(object sender, EventArgs e)
        {
           
        }

        private void Reiniciar() //Método que aplica el código de inicialización del juego, para que se reseteen la elección de preguntas y respuestas.
        {
            if (!modoCapitales)
            {
                pais = azar.Next(listaPaises.Length - 1);
                posRespuestaCorrecta = azar.Next(4);
                TxtPais.Text = listaPaises[pais];

                switch (posRespuestaCorrecta)
                {
                    case 0:
                        TxtRespuestaCero.Text = listaCapitales[pais];
                        break;
                    case 1:
                        TxtRespuestaUno.Text = listaCapitales[pais];
                        break;
                    case 2:
                        TxtRespuestaDos.Text = listaCapitales[pais];
                        break;
                    default:
                        TxtRespuestaTres.Text = listaCapitales[pais];
                        break;
                }
            }
            else
            {
                pais = azar.Next(listaPaises.Length - 1);
                posRespuestaCorrecta = azar.Next(4);
                TxtPais.Text = listaCapitales[pais];

                switch (posRespuestaCorrecta)
                {
                    case 0:
                        TxtRespuestaCero.Text = listaPaises[pais];
                        break;
                    case 1:
                        TxtRespuestaUno.Text = listaPaises[pais];
                        break;
                    case 2:
                        TxtRespuestaDos.Text = listaPaises[pais];
                        break;
                    default:
                        TxtRespuestaTres.Text = listaPaises[pais];
                        break;
                }
            }

            do
            {
                respuestaIncorrectaUno = azar.Next(listaPaises.Length-1);
            } while (respuestaIncorrectaUno == pais);

            do
            {
                respuestaIncorrectaDos = azar.Next(listaPaises.Length - 1);
            } while (respuestaIncorrectaDos == respuestaIncorrectaUno || respuestaIncorrectaDos == pais);

            do
            {
                respuestaIncorrectaTres = azar.Next(listaPaises.Length - 1);
            } while (respuestaIncorrectaTres == respuestaIncorrectaUno || respuestaIncorrectaTres == respuestaIncorrectaDos || respuestaIncorrectaTres == pais);

            do
            {
                posRespuestaIncorrectaUno = azar.Next(4);
            } while (posRespuestaIncorrectaUno == posRespuestaCorrecta);

            do
            {
                posRespuestaIncorrectaDos = azar.Next(4);
            } while (posRespuestaIncorrectaDos == posRespuestaCorrecta || posRespuestaIncorrectaDos == posRespuestaIncorrectaUno);

            do
            {
                posRespuestaIncorrectaTres = azar.Next(4);
            } while (posRespuestaIncorrectaTres == posRespuestaCorrecta || posRespuestaIncorrectaTres == posRespuestaIncorrectaUno || posRespuestaIncorrectaTres == posRespuestaIncorrectaDos);

            if (!modoCapitales) 
            { 

                switch (posRespuestaIncorrectaUno)
                {
                    case 0:
                        TxtRespuestaCero.Text = listaCapitales[respuestaIncorrectaUno];
                        break;
                    case 1:
                        TxtRespuestaUno.Text = listaCapitales[respuestaIncorrectaUno];
                        break;
                    case 2:
                        TxtRespuestaDos.Text = listaCapitales[respuestaIncorrectaUno];
                        break;
                    default:
                        TxtRespuestaTres.Text = listaCapitales[respuestaIncorrectaUno];
                        break;
                }

                switch (posRespuestaIncorrectaDos)
                {
                    case 0:
                        TxtRespuestaCero.Text = listaCapitales[respuestaIncorrectaDos];
                        break;
                    case 1:
                        TxtRespuestaUno.Text = listaCapitales[respuestaIncorrectaDos];
                        break;
                    case 2:
                        TxtRespuestaDos.Text = listaCapitales[respuestaIncorrectaDos];
                        break;
                    default:
                        TxtRespuestaTres.Text = listaCapitales[respuestaIncorrectaDos];
                        break;
                }

                switch (posRespuestaIncorrectaTres)
                {
                    case 0:
                        TxtRespuestaCero.Text = listaCapitales[respuestaIncorrectaTres];
                        break;
                    case 1:
                        TxtRespuestaUno.Text = listaCapitales[respuestaIncorrectaTres];
                        break;
                    case 2:
                        TxtRespuestaDos.Text = listaCapitales[respuestaIncorrectaTres];
                        break;
                    default:
                        TxtRespuestaTres.Text = listaCapitales[respuestaIncorrectaTres];
                        break;
                }

             }

            else
            {
                switch (posRespuestaIncorrectaUno)
                {
                    case 0:
                        TxtRespuestaCero.Text = listaPaises[respuestaIncorrectaUno];
                        break;
                    case 1:
                        TxtRespuestaUno.Text = listaPaises[respuestaIncorrectaUno];
                        break;
                    case 2:
                        TxtRespuestaDos.Text = listaPaises[respuestaIncorrectaUno];
                        break;
                    default:
                        TxtRespuestaTres.Text = listaPaises[respuestaIncorrectaUno];
                        break;
                }

                switch (posRespuestaIncorrectaDos)
                {
                    case 0:
                        TxtRespuestaCero.Text = listaPaises[respuestaIncorrectaDos];
                        break;
                    case 1:
                        TxtRespuestaUno.Text = listaPaises[respuestaIncorrectaDos];
                        break;
                    case 2:
                        TxtRespuestaDos.Text = listaPaises[respuestaIncorrectaDos];
                        break;
                    default:
                        TxtRespuestaTres.Text = listaPaises[respuestaIncorrectaDos];
                        break;
                }

                switch (posRespuestaIncorrectaTres)
                {
                    case 0:
                        TxtRespuestaCero.Text = listaPaises[respuestaIncorrectaTres];
                        break;
                    case 1:
                        TxtRespuestaUno.Text = listaPaises[respuestaIncorrectaTres];
                        break;
                    case 2:
                        TxtRespuestaDos.Text = listaPaises[respuestaIncorrectaTres];
                        break;
                    default:
                        TxtRespuestaTres.Text = listaPaises[respuestaIncorrectaTres];
                        break;
                }
            }

            if (reinicioModo)
            {
                numPreguntas = 0;
                preguntasAcertadas = 0;
                acertadasPorcentaje = 0;
                reinicioModo = false;
            }
            botonSiguiente = false;
        }

        private void ReiniciarModoRespuesta()
        {
            pais = azar.Next(listaPaises.Length - 1);

            if (!modoCapitales)
            {
                TxtPais.Text = listaPaises[pais];
            }
            else
            {
                TxtPais.Text = listaCapitales[pais];
            }

            if (reinicioModo)
            {
                numPreguntas = 0;
                preguntasAcertadas = 0;
                acertadasPorcentaje = 0;
                reinicioModo = false;
            }

            //Comprobamos que si hay algún valor en las respuestas anteriores, lo dejamos vacio

            if(TxtRespuestaCero.Text!=null)
            {
                TxtRespuestaCero.Text = "";
                TxtRespuestaUno.Text = "";
                TxtRespuestaDos.Text = "";
                TxtRespuestaTres.Text = "";
            }
            botonSiguiente = false;
        } //Método que reinicia el juego en modo Respuesta Escrita

        private void clickRespuesta(object sender, EventArgs e)
        {
            TextBox caja = (TextBox)sender;

            //Primero comprobaremos que el usuario no haya contestado ya a la pregunta con el booleano botonSiguiente y que no estemos en el modo de escribir respuesta

            if (!botonSiguiente && !modoRespuesta)
            {

                //A continuación comprobaremos en qué modo de juego estamos, si en mostrar países o capitales

                if (!modoCapitales)
                {
                    //Ahora deberemos comprobar que la respuesta clickeada sea la correcta. Para ello comprobaremos si el texto escrito sobre la caja corresponde al mismo del array de capitales. Si es así, la respuesta será correcta

                    switch (caja.Name)
                    {
                        case "TxtRespuestaCero":
                            if (TxtRespuestaCero.Text.Equals(listaCapitales[pais]))
                            {
                                preguntasAcertadas++;
                                TxtRespuestaEscrita.Text = "Correcto!!";
                                botonSiguiente = true;
                            }
                            else
                            {
                                TxtRespuestaEscrita.Text = "Incorrecto =(";
                            }
                            break;

                        case "TxtRespuestaUno":
                            if (TxtRespuestaUno.Text.Equals(listaCapitales[pais]))
                            {
                                preguntasAcertadas++;
                                TxtRespuestaEscrita.Text = "Correcto!!";
                            }
                            else
                            {
                                TxtRespuestaEscrita.Text = "Incorrecto =(";
                            }
                            break;

                        case "TxtRespuestaDos":
                            if (TxtRespuestaDos.Text.Equals(listaCapitales[pais]))
                            {
                                preguntasAcertadas++;
                                TxtRespuestaEscrita.Text = "Correcto!!";
                            }
                            else
                            {
                                TxtRespuestaEscrita.Text = "Incorrecto =(";
                            }
                            break;

                        case "TxtRespuestaTres":
                            if (TxtRespuestaTres.Text.Equals(listaCapitales[pais]))
                            {
                                preguntasAcertadas++;
                                TxtRespuestaEscrita.Text = "Correcto!!";
                            }
                            else
                            {
                                TxtRespuestaEscrita.Text = "Incorrecto =(";
                            }
                            break;
                    }
                }

                //Si estamos en el modo capitales, cambiamos la comprobación de las respuestas correctas

                else
                {
                    switch (caja.Name)
                    {
                        case "TxtRespuestaCero":
                            if (TxtRespuestaCero.Text.Equals(listaPaises[pais]))
                            {
                                preguntasAcertadas++;
                                TxtRespuestaEscrita.Text = "Correcto!!";
                                botonSiguiente = true;
                            }
                            else
                            {
                                TxtRespuestaEscrita.Text = "Incorrecto =(";
                            }
                            break;

                        case "TxtRespuestaUno":
                            if (TxtRespuestaUno.Text.Equals(listaPaises[pais]))
                            {
                                preguntasAcertadas++;
                                TxtRespuestaEscrita.Text = "Correcto!!";
                            }
                            else
                            {
                                TxtRespuestaEscrita.Text = "Incorrecto =(";
                            }
                            break;

                        case "TxtRespuestaDos":
                            if (TxtRespuestaDos.Text.Equals(listaPaises[pais]))
                            {
                                preguntasAcertadas++;
                                TxtRespuestaEscrita.Text = "Correcto!!";
                            }
                            else
                            {
                                TxtRespuestaEscrita.Text = "Incorrecto =(";
                            }
                            break;

                        case "TxtRespuestaTres":
                            if (TxtRespuestaTres.Text.Equals(listaPaises[pais]))
                            {
                                preguntasAcertadas++;
                                TxtRespuestaEscrita.Text = "Correcto!!";
                            }
                            else
                            {
                                TxtRespuestaEscrita.Text = "Incorrecto =(";
                            }
                            break;
                    }
                }
                botonSiguiente = true; //Al responder a la pregunta, permitimos que el usuario pulse el botón siguiente
                numPreguntas++;

                //Ahora mostramos el resultado que llevamos de aciertos en la caja que corresponde

                acertadasPorcentaje = preguntasAcertadas * 100 / numPreguntas;
                TxtPorcentaje.Text = Convert.ToString(acertadasPorcentaje) + "%";
            }
        } //Método que gestiona los clicks de las respuestas

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (botonSiguiente)
            {
                if (!modoRespuesta)
                {
                    Reiniciar();
                }
                else
                {
                    ReiniciarModoRespuesta();
                }
            }
               
            TxtRespuestaEscrita.Text = "";
        } //Método que gestiona el botón "siguiente"

        private void BtnSalir_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Hasta luego"); 
           this.Close();
        } //Método que gestiona los botones "salir"

        private void MnuOpcionesPaises_Click(object sender, EventArgs e)
        {
            //Si ya estamos en el menú de nombre capitales, no hacemos nada
            if(!modoCapitales)
            {
                //Al clickar en este botón reiniciamos el juego en modo capitales
                LblPais.Text = "Capital:";
                LblCapital.Text = "Pais:";

                modoCapitales = true;
                reinicioModo = true;
                TxtPorcentaje.Text = "";

                //Si hay contenido en la caja de texto de la respuesta lo borramos
                if (TxtRespuestaEscrita.Text != null)
                    TxtRespuestaEscrita.Text = "";

                //Quitamos el check del menú opciones nombre capitales como respuestas y lo añadimos al de paises
                MnuOpcionesCapitales.Checked = false;
                MnuOpcionesPaises.Checked = true;

                //Comprobamos en qué modo de juego estamos para hacer un reinicio u otro
                if (modoRespuesta)
                    ReiniciarModoRespuesta();
                else
                    Reiniciar();
            } 
        } //Método que gestiona el modo de juego para jugar con países

        private void MnuPartidaNueva_Click(object sender, EventArgs e)
        {
            //Al hacer click aquí, reiniciaremos todo manteniendo las opciones que tengamos
            TxtPorcentaje.Text = "";
            //Si hay contenido en la caja de texto de la respuesta lo borramos
            if (TxtRespuestaEscrita.Text != null)
                TxtRespuestaEscrita.Text = "";
            //La opcion reinicio modo la activamos para que el contador de preguntas hechas y acertadas se reinicie
            reinicioModo = true;
            //Comprobamos en qué modo estamos y actuamos en consecuencia
            if (!modoRespuesta)
                Reiniciar();
            else
                ReiniciarModoRespuesta();
        } //Método que gestiona el botón de partida "nueva"

        private void MnuOpcionesCapitales_Click(object sender, EventArgs e)
        {
            //Al clickar en este botón reiniciamos el juego en modo paises
            //Si ya estamos en el menu de nombre paises, no hacemos nada
            if (modoCapitales)
            {
                LblPais.Text = "Pais:";
                LblCapital.Text = "Capital:";

                modoCapitales = false;
                reinicioModo = true;
                TxtPorcentaje.Text = "";

                //Si hay contenido en la caja de texto de la respuesta lo borramos
                if (TxtRespuestaEscrita.Text != null)
                    TxtRespuestaEscrita.Text = "";

                //Quitamos el check del menú opciones nombre paises como respuestas y lo añadimos al de capitales
                MnuOpcionesPaises.Checked = false;
                MnuOpcionesCapitales.Checked = true;

                //Comprobamos en qué modo de juego estamos para hacer un reinicio u otro
                if (modoRespuesta)
                    ReiniciarModoRespuesta();
                else
                    Reiniciar();
            }
        } //Método que gestiona el modo de juego para jugar con capitales

        private void MnuOpcionesMultiplesOpciones_Click(object sender, EventArgs e)
        {
            //Si ya estamos en el menú de múltiples opciones, no hacemos nada
            if (!modoOpciones)
            {
                MnuOpcionesMultiplesOpciones.Checked = true;
                MnuOpcionesEscribirRespuesta.Checked = false;
                reinicioModo = true;
                modoOpciones = true;
                modoRespuesta = false;
                TxtPorcentaje.Text = "";
                if (TxtRespuestaEscrita.Text != null)
                    TxtRespuestaEscrita.Text = "";
                Reiniciar();
            }
        } //Método que gestiona el modo de juego para jugar con múltiples opciones

        private void MnuOpcionesEscribirRespuesta_Click(object sender, EventArgs e)
        {
            //Si ya estamos en el menú de escribir respuesta, no hacemos nada
            if (!modoRespuesta)
            {
                MnuOpcionesMultiplesOpciones.Checked = false;
                MnuOpcionesEscribirRespuesta.Checked = true;
                reinicioModo = true;
                TxtPorcentaje.Text = "";
                modoOpciones = false;
                modoRespuesta = true;
                if (TxtRespuestaEscrita.Text != null)
                    TxtRespuestaEscrita.Text = "";
                ReiniciarModoRespuesta();
            }
        } //Método que gestiona el modo de juego para jugar escribiendo la respuesta

        private void TxtRespuestaEscrita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (modoRespuesta && !botonSiguiente)
            {
                if (!modoCapitales)
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    {
                        if (TxtRespuestaEscrita.Text.Equals(listaCapitales[pais]))
                        {
                            preguntasAcertadas++;
                            TxtRespuestaEscrita.Text = "Correcto!!";
                            botonSiguiente = true;
                        }
                        else
                        {
                            TxtRespuestaEscrita.Text = "Incorrecto =(";
                        }
                        botonSiguiente = true; //Al responder a la pregunta, permitimos que el usuario pulse el botón siguiente
                        numPreguntas++;
                        acertadasPorcentaje = preguntasAcertadas * 100 / numPreguntas;
                        TxtPorcentaje.Text = Convert.ToString(acertadasPorcentaje) + "%";
                    }
                }
                else
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    {
                        if (TxtRespuestaEscrita.Text.Equals(listaPaises[pais]))
                        {
                            preguntasAcertadas++;
                            TxtRespuestaEscrita.Text = "Correcto!!";
                            botonSiguiente = true;
                        }
                        else
                        {
                            TxtRespuestaEscrita.Text = "Incorrecto =(";
                        }
                        botonSiguiente = true; //Al responder a la pregunta, permitimos que el usuario pulse el botón siguiente
                        numPreguntas++;
                        acertadasPorcentaje = preguntasAcertadas * 100 / numPreguntas;
                        TxtPorcentaje.Text = Convert.ToString(acertadasPorcentaje) + "%";
                    }
                }

            }
                
        } //Metodo que controla que se pulse "enter" para enviar la respuesta en modo escrito
    }
}