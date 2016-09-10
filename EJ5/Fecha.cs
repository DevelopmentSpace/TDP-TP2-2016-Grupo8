namespace EJ5
{
    /// <summary>
    /// Permite crear fechas y agregar dias, meses, años a las mismas; ver dia de la semana y comparar 2 fechas 
    /// </summary>
    public class Fecha
    {
        /// <summary>
        /// Cantidad de dias que tienen los meses (bisiestos y no bisiestos)
        /// </summary>
        private static readonly int[] DIAS_MESES = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DIAS_MESES_BISIESTO = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// <summary>
        /// Modulo de los meses (bisiestos y no bisiestos). Se utiliza para calcular que dia de la semana corresponde a una fecha
        /// </summary>
        private static readonly int[] MODULO_MESES = {0, 3, 3, 6, 1, 4, 6, 2, 5 ,0 ,3 ,5};
        private static readonly int[] MODULO_MESES_BISIESTO = {0, 3, 4, 0, 2, 5, 0, 3, 6, 1, 4, 6 };

        /// <summary>
        /// Permite conparar 2 fechas
        /// </summary>
        /// <param name="pFecha1">Fecha 1</param>
        /// <param name="pFecha2">Fecha 2</param>
        /// <returns>-1 (fecha 1 menor fecha 2), 0 (fecha 1 igual fecha 2), 1 ( fecha 2 mayor fecha 1)</returns>
        public static int CompararFechas(Fecha pFecha1, Fecha pFecha2)
        {
            //Compara la relacion entre los años
            if (pFecha1.iA < pFecha2.iA)
                return -1;
            else if (pFecha1.iA > pFecha2.iA)
                return 1;
            else
            {
                //Compara la relacion entre los meses
                if (pFecha1.iM < pFecha2.iM)
                    return -1;
                else if (pFecha1.iM > pFecha2.iM)
                    return 1;
                else
                {
                    //Compara la relacion entre los dias
                    if (pFecha1.iD < pFecha2.iD)
                        return -1;
                    else if (pFecha1.iD > pFecha2.iD)
                        return 1;
                    else
                        return 0;
                }
            }

        }





        /// <summary>
        /// Variables para guardar Dia, Mes y Año respectivamente;
        /// </summary>
        readonly int iD, iM, iA;

        /// <summary>
        /// Constructor en base a dia, mes y año
        /// </summary>
        /// <param name="pD">Dia</param>
        /// <param name="pM">Mes</param>
        /// <param name="pA">Año</param>
        public Fecha(int pD, int pM, int pA)
        {
            iD = pD;
            iM = pM;
            iA = pA;
        }

        /// <summary>
        /// Property Dia (solo lectura)
        /// </summary>
        public int Dia
        {
            get { return iD; }
        }

        /// <summary>
        /// Property Mes (solo lectura)
        /// </summary>
        public int Mes
        {
            get { return iM; }
        }

        /// <summary>
        /// Property Año (solo lectura)
        /// </summary>
        public int Año
        {
            get { return iA; }
        }

        /// <summary>
        /// Metodo para saber si el año es bisiesto
        /// </summary>
        /// <returns>True (bisiesto), False (no bisiesto)</returns>
        public bool AñoBisiesto()
        {
            return ((iA % 4) == 0 && ((iA % 100) != 0 || (iA % 400) == 0));
        }

        /// <summary>
        /// Permite agregar dias a una fecha
        /// </summary>
        /// <param name="pCantidad">Cantidad de dias</param>
        /// <returns>Nueva fecha con los dias agregados</returns>
        public Fecha AgregarDias(int pCantidad)
        {
            string.Format()
            int diasParaFinMes;
            //Calculas los dias faltantes para fin de mes, apartir de un arreglo u otro, segun el año sea bisiesto o no
            if (this.AñoBisiesto())
                diasParaFinMes = DIAS_MESES_BISIESTO[iM - 1] - iD;
            else
                diasParaFinMes = DIAS_MESES[iM - 1] - iD;

            //Si hay que sumar mas dias que los que faltan para fin de mes, pasa al mes siguiente y realiza el proceso de agregar dias
            //para la nueva fecha con los dias que falten sumar, de manera recursiva
            if (pCantidad > diasParaFinMes)
                if (iM == 12) //Si el mes es 12
                        return new Fecha(1, 1, iA + 1).AgregarDias(pCantidad -(diasParaFinMes + 1));
                    else
                        return new Fecha(1, iM + 1, iA).AgregarDias(pCantidad -(diasParaFinMes + 1));
            else
                //Si hay que sumar menos dias de los que faltan para fin de mes, entoces lo suma directamente
                return new Fecha(iD + pCantidad, iM, iA);
            
        }

        /// <summary>
        /// Permite agregar meses a una fecha
        /// </summary>
        /// <param name="pCantidad">Cantidad de meses a agregar</param>
        /// <returns>Nueva fecha con los meses agregados</returns>
        public Fecha AgregarMeses(int pCantidad)
        {
            int mesesParaFinAño;
            //Calcula los meses que faltan para fin de año
            mesesParaFinAño = 12 - iM;

            //Si la cantidad de meses a sumar es mayor que los que faltan para fin de año, entonces de manera recursiva
            //pasa al año siguiente y suma la cantidad de meses faltantes
            if (pCantidad > mesesParaFinAño)
                return new Fecha(iD, 1, iA + 1).AgregarMeses(pCantidad - (mesesParaFinAño + 1));
            else
                //Si no los suma directamente
                return new Fecha(iD, iM + pCantidad, iA);

        }

        /// <summary>
        /// Permite agregar años a una fecha
        /// </summary>
        /// <param name="pCantidad">Cantidad de años a sumar</param>
        /// <returns>Nueva fecha con los años agregados</returns>
        public Fecha AgregarAños(int pCantidad)
        {
            return new Fecha(iD, iM, iA + pCantidad);

        }

        /// <summary>
        /// Devuelve el dia de la semana
        /// </summary>
        /// <returns>Valor del enumerable DiaSemana correspondiente al dia de la fecha</returns>
        public DiaSemana DiaDeLaSemana()
        {
            int modulo;

            //Obtiene el modulo correspondiente al mes, segun el año sea bisiesto o no

            if (this.AñoBisiesto())
                modulo = MODULO_MESES_BISIESTO[iM - 1];
            else
                modulo = MODULO_MESES[iM - 1];

            //Calcula el dia y lo devuelve
            return (DiaSemana)(((iA-1)%7 + ((iA-1)/4 - 3*((iA-1)/100+1)/4)%7 + modulo + iD%7)%7);
        }

       
    }
}
