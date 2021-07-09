using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ia_toniazo
{
    public class Prediction
    {
        [ColumnName("Score")]
        public float Valor { get; set; }
    }
    public class DatasetModel
    {
        [LoadColumn(9)]
        public float Valor { get; set; }
        [LoadColumn(0)]
        public float TamanhoTotal { get; set; }
        [LoadColumn(0)]
        public float TamanhoPrivativo { get; set; }
        [LoadColumn(0)]
        public float Bairro { get; set; }
        [LoadColumn(1)]
        public float Quartos { get; set; }
        [LoadColumn(1)]
        public float Garagem { get; set; }
        [LoadColumn(2)]
        public float Suite { get; set; }
        [LoadColumn(9)]
        public float Tipo { get; set; }

        public DatasetModel()
        {

        }
        public DatasetModel(
                int Tipo,
                int Bairro,
                double Valor,
                int Quartos,
                int Suite,
                int Garagem,
                double TamanhoPrivativo,
                double TamanhoTotal
            )
        {
            this.Valor = Convert.ToSingle(TamanhoPrivativo);
            this.TamanhoPrivativo = Convert.ToSingle(TamanhoPrivativo);
            this.TamanhoTotal = Convert.ToSingle(TamanhoTotal);

            this.Bairro = Bairro;
            this.Quartos = Quartos;
            this.Garagem = Garagem;
            this.Suite = Suite;
            this.Tipo = Tipo;

            this.Tipo = Tipo;


        }
        public Bairro IntToBairro(int value)
        {
            Bairro e = (Bairro)value;
            return e;
        }
    }

    public enum Bairro
    {
        Centro = 11,
        Efapi = 17,
        JardimItália = 24,
        PresidenteMédici = 35,
        SãoCristóvão = 42,
        Universitário = 47,

    }
    public static class Populate
    {
        public static List<DatasetModel> Training()
        {
            return new List<DatasetModel>()
            {
new DatasetModel(2, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94),
new DatasetModel(2, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(2, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(2, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(3, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(2, 35, 550000, 1, 1, 2, 134, 134 ),
new DatasetModel(2, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(2, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(3, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(2, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(3, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(3, 35, 550000, 1, 1, 2, 134, 134 ),
new DatasetModel(2, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(2, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(2, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(3, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(2, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(3, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(2, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(3, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(2, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94),
new DatasetModel(2, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(2, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(2, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(3, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(2, 35, 550000, 1, 1, 2, 134, 134 ),
new DatasetModel(2, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(2, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(3, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(2, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(3, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(3, 35, 550000, 1, 1, 2, 134, 134 ),
new DatasetModel(2, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(2, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(2, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(3, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(2, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(3, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(2, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(3, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
new DatasetModel(1, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
new DatasetModel(1, 24, 650000, 2, 1, 2, 113.2, 138.99),
new DatasetModel(1, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
new DatasetModel(1, 35, 550000, 1, 1, 2, 134, 134  ),
new DatasetModel(1, 11, 379000, 2, 0, 1, 47.17, 96.13 ),
new DatasetModel(1, 24, 420000, 1, 1, 2, 69.59, 118.48),
new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),

            };
        }
    }
}
