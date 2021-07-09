using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ia_toniazo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var data = new CreateDataBySantaMaria().CreateData();
            MLContext mlContext = new MLContext(seed:1);
            var trainingData = Populate.Training();
            var model = Train(mlContext, trainingData);
            Evaluate(mlContext, model);
            TestSinglePrediction(mlContext, model);

        }

        public static ITransformer Train(MLContext mlContext, List<DatasetModel> data)
        {
            IDataView dataView = mlContext.Data.LoadFromEnumerable<DatasetModel>(data);
            var pipeline = mlContext.Transforms.CopyColumns(outputColumnName: "Label", inputColumnName: "Valor")
            .Append(mlContext.Transforms.Concatenate("Features",
                    "TamanhoTotal",
                    "TamanhoPrivativo",
                    "Bairro",
                    "Suite",
                    "Quartos",
                    "Garagem"))
            .Append(mlContext.Regression.Trainers.FastTreeTweedie(numberOfLeaves: 50, numberOfTrees: 250,  minimumExampleCountPerLeaf: 80,  learningRate: 0.9));
            var model = pipeline.Fit(dataView);
            return model;
        }

        private static void Evaluate(MLContext mlContext, ITransformer model)
        {
            var testeData = new List<DatasetModel>()
            {
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
                new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
                new DatasetModel(2, 11, 350000, 1, 0, 1, 36.03, 61.83 ),
                new DatasetModel(3, 24, 650000, 2, 1, 2, 113.2, 138.99),
                new DatasetModel(2, 11, 300000, 0, 1, 1, 47.22, 60.76 ),
                new DatasetModel(3, 35, 550000, 1, 1, 2, 134, 134  ),
                new DatasetModel(1, 47, 230000, 2, 1, 1, 79.84, 125.79),
                new DatasetModel(1, 16, 230000, 2, 0, 1, 48.3, 94  ),
                new DatasetModel(1, 11, 318000, 1, 0, 0, 36.03, 61.83 ),
                new DatasetModel(1, 42, 589000, 2, 1, 2, 99.7, 99.7),
                new DatasetModel(1, 35, 190000, 2, 0, 1, 52.65, 59.29 ),
            };

            IDataView dataView = mlContext.Data.LoadFromEnumerable<DatasetModel>(testeData);
            var predictions = model.Transform(dataView);
            var metrics = mlContext.Regression.Evaluate(predictions, "Label", "Score");
            /*Console.WriteLine();
            Console.WriteLine($"*************************************************");
            Console.WriteLine($"*   Metricas de Analise de testes com {testeData.Count} itens   ");
            Console.WriteLine($"*------------------------------------------------");
            Console.WriteLine($"*     Coeficiente de determinação:   {metrics.RSquared}");
            Console.WriteLine($"*     Raiz quadrada do erro-médio:   {metrics.RootMeanSquaredError}");
            Console.WriteLine($"*     Função de perda :   {metrics.LossFunction}");
            Console.WriteLine($"*     Erro Quadrático Médio:   {metrics.MeanSquaredError}");
            Console.WriteLine($"*     Erro médio absoluto:   {metrics.MeanAbsoluteError}");
            Console.WriteLine($"*************************************************");*/

        }

        private static void TestSinglePrediction(MLContext mlContext, ITransformer model)
        {
            var predictionFunction = mlContext.Model.CreatePredictionEngine<DatasetModel, Prediction>(model);
            var simpleOffer = new DatasetModel()
            {
                TamanhoTotal = 59F,
                TamanhoPrivativo = 52F,
                Bairro = (int) Bairro.Efapi,
                Quartos = 2,
                Suite = 0,
                Garagem = 1,
                Valor = 0F
            };
            var prediction = predictionFunction.Predict(simpleOffer);
            /*Console.WriteLine($"**********************************************************************");
            Console.WriteLine($"Teste de previsão: Tamanho:{simpleOffer.TamanhoTotal} = {(((prediction.Valor) * simpleOffer.TamanhoTotal) / 10):0.####}");
            Console.WriteLine($"**********************************************************************");*/
            Thread.Sleep(30000);
        }
    }
}
