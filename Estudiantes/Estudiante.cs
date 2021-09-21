using System;

namespace Domain
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Carnet { get; set; }

        public int[] notas=new int[6];

        public decimal GetPromedio()
        {
            decimal promedio = 0;
            foreach (int i in notas) 
            {
                promedio += i; 
            }
            return promedio / 6;

        }

        public void Add(string nota,  int count)
        {
            int not;
            if (int.TryParse(nota, out not))
            {
                if (not<0 || not>100) { 
                throw new ArgumentOutOfRangeException();
                }
                else
                {
                    notas[count] = not;
                }
            }
           
        }
    }
}
