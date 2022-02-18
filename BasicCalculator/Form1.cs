using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        //Variables para realizar las operaciones matematicas
        double resultado = 0;
        double num2 = 0;
        string operacion="";
        bool hayOperacion = false;

        //Metodo constructor
        public Form1()
        {
            InitializeComponent();
        }
        //Acciones para cualquiera de los botones de los numeros
        private void btn1_Click(object sender, EventArgs e)
        {
            // Declare un objeto de tipo boton para poder asignar lo que este contenga en el texto al area de resultados
            Button button = (Button)sender;
            // Si esta variable es igual a true el area de resultado se limpia ya que se prepara para guardar el sigiente valor
            if (hayOperacion==true)
            {
                txtres.Text ="";        
            }   
            hayOperacion = false;
            //En caso de que el boton seleccionado en su texto sea igual a punto 
            //Verificara si el area txtres esta vacio si lo esta agregara 0. al igual que el label txtshow
            if (button.Text == ".")
            {
                if (txtres.Text.Equals(""))
                {
                    txtres.Text = "0.";
                    txtshow.Text = txtshow.Text + "0.";
                }
                //Pero si en txtres no hay un . o es igual a 0 se procedera a insertar el punto en el proximo espacio del txtres y el txtshow
                else if (!txtres.Text.Contains(".")||txtres.Text.Equals("0"))
                {
                    txtres.Text =txtres.Text + ".";
                    txtshow.Text = txtshow.Text + ".";
                }

            }
            //En caso de que nada de lo anterior fuese true se agregara el texto que contenga el objeto de tipo
            //boton a continuacion del txto que este insertado, lo mismo para el txtshow
            else
            {
                txtres.Text = txtres.Text + button.Text;
                txtshow.Text = txtshow.Text + button.Text;
            }


        }
        //Acciones para todos los botones de las operaciones +, -, *, y / 
        //Cada uno de estos botones tiene caracteristicas diferentes
        private void btnmas_Click(object sender, EventArgs e)
        {//Con el objeto button atrapo el boton seleccionado ya que cada uno en la accion de clic tienen el mismo metodo
               Button button = (Button)sender;

            //Si txtres no es igual a cadena vacia procede a ejecutar lo que hay en su interior
            if (!txtres.Text.Equals(""))
            {
                
                // Esta linea de codigo me permite ejecutar el metodo asociado a btnigual con el metodo PerformClick()
                //btnigual.PerformClick();
                //Si el txtres no contiene nada no se realizan operaciones 
                if (txtres.Text.Equals(""))
                {

                }
                else if (txtshow.Text.Contains("="))
                {

                }
                //de lo contrario num2 pasa a tomar el valor que hay en txtres
                else
                {
                    num2 = Double.Parse(txtres.Text);
                }
                //con esta condicion se verifica a que es igual la operacion y se ejecuta el caso correspondiente a su valor
                switch (operacion)
                {
                    case "+":
                        txtres.Text = Convert.ToString(resultado + num2);
                        break;

                    case "-":
                        txtres.Text = Convert.ToString(resultado - num2);
                        break;

                    case "×":
                        txtres.Text = Convert.ToString(resultado * num2);
                        break;
                    case "÷":
                        if (num2 == 0)
                        {
                            txtres.Text = "Error de Sintaxis";
                        }
                        else
                        {
                            txtres.Text = Convert.ToString(resultado / num2);
                        }

                        break;

                }
                //resultado pasa a ser igual a lo que hay en txtres
                resultado = Double.Parse(txtres.Text);
                txtshow.Text = txtres.Text;
                //La variable operacion pasa a ser igual al texto que contenga el boton que se haya seleccionado
                operacion = button.Text;
                //Pasa a ser true
                hayOperacion = true;
                txtshow.Text = txtshow.Text + " " + button.Text + " ";
            }
        
           
        }
        //Acciones para el boton de igual tambien se ejecuta para cualquiera de los botones de operaciones
        private void btnigual_Click(object sender, EventArgs e)
        {
            //Si el txtres no contiene nada no se realizan operaciones 
            if (txtres.Text.Equals(""))
            {

            }
            else if (txtshow.Text.Contains("="))
            {

            }
            //de lo contrario num2 pasa a tomar el valor que hay en txtres
            else
            {
                num2 = Double.Parse(txtres.Text);
            } 
            //con esta condicion se verifica a que es igual la operacion y se ejecuta el caso correspondiente a su valor
            switch (operacion)
            {
                case "+":
                    txtres.Text = Convert.ToString(resultado + num2);
                    break;

                case "-":
                    txtres.Text = Convert.ToString(resultado - num2);
                    break;

                case "×":
                    txtres.Text = Convert.ToString(resultado * num2);          
                    break;
                case "÷":
                    if (num2==0)
                    {
                        txtres.Text = "Error de Sintaxis";
                    }
                    else
                    {
                        txtres.Text = Convert.ToString(resultado / num2);
                    }
                       
                    break;

            }
            
            txtshow.Text = Convert.ToString(resultado + " " + operacion + " " + num2 + "=" );
        }
        //Acciones para resetear la calculadora 
        private void btnreset_Click(object sender, EventArgs e)
        {
            resultado = 0;
            operacion = "";
            hayOperacion = false;
            num2 = 0 ;
            txtres.Text = "";
            txtshow.Text = "";
        }
        //Acciones para borrar digitos uno por uno
        private void btnborrar_Click(object sender, EventArgs e)
        {
            //Este try es para evitar que el programa se cierre cuando intentemos borrar 
            //con el cuadro de texto vacio o sea sin numeros
            try
            {
                //Este codigo me permite que los numeros se eliminen uno a uno
                string number = txtres.Text;
                int largo = (number.Length - 1);
                string number2 = number.Remove(largo, 1);
                txtres.Text = number2;
                txtshow.Text = resultado + " "+ operacion + " " + number2;
            }
            catch (ArgumentOutOfRangeException exec)
            {

            }
        }
    }
}
