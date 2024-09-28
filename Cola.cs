using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones_C_Sharp
{
    public class Cola
    {
        public Personas? Primero = null;
        public Personas? Ultimo = null;

        public void Encolar(Personas newP)
        {
            if (Primero == null)
            {
                Primero = newP;
                Ultimo = newP;
            }
            else
            {
                Ultimo._Next =newP;
                Ultimo = newP;
            }

        }
        public void Desencolar()
        {
            try
            {
                if (Primero == null)
                {
                    Ultimo = null; /// Podria quitarse
                    throw new Exception("Nada para desencolar");
                }
                else
                {
                    Primero = Primero._Next;
                }
                if (Primero == null)
                {
                    Ultimo = null;
                }


            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }
        public void Modificar( Personas newP , Personas newP2 )
        {
            try
            {

                if (Primero == null)
                {
                    throw new Exception("La cola está vacía, no se puede modificar.");
                }

                Personas? aux = Primero;
                bool found = false;

                while (aux != null)
                {
                    if (aux.Id == newP.Id)
                    {
                        
                        aux.Nombre = newP2.Nombre;
                        aux.Fecha = newP2.Fecha;
                        aux.Id = newP2.Id;
                        found = true;
                        break;
                    }
                    aux = aux._Next;
                }

                if (!found)
                {
                    throw new Exception($"No se encontró la persona con ID {newP.Id}.");
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show($"{EX.Message}"); 
            } 
        }
    }
}
