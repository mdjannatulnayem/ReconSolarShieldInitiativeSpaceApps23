﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace RSSI_webAPI
{
    public partial class RssiRegressionEngine
    {
        /// <summary>
        /// model input class for RssiRegressionEngine.
        /// </summary>
        #region model input class
        public class ModelInput
        {

            [LoadColumn(1)]
            [ColumnName(@"year")]
            public float Year { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"month")]
            public float Month { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"bx_gsm")]
            public float Bx_gsm { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"by_gsm")]
            public float By_gsm { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"bz_gsm")]
            public float Bz_gsm { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"bt")]
            public float Bt { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"intensity")]
            public float Intensity { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"declination")]
            public float Declination { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"inclination")]
            public float Inclination { get; set; }

            [LoadColumn(10)]
            [ColumnName(@"north")]
            public float North { get; set; }

            [LoadColumn(11)]
            [ColumnName(@"east")]
            public float East { get; set; }

            [LoadColumn(12)]
            [ColumnName(@"vertical")]
            public float Vertical { get; set; }

            [LoadColumn(13)]
            [ColumnName(@"horizontal")]
            public float Horizontal { get; set; }

            [LoadColumn(14)]
            [ColumnName(@"class")]
            public float Class { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for RssiRegressionEngine.
        /// </summary>
        #region model output class
        public class ModelOutput
        {

            [ColumnName(@"year")]
            public float Year { get; set; }

            [ColumnName(@"month")]
            public float Month { get; set; }

            [ColumnName(@"bx_gsm")]
            public float Bx_gsm { get; set; }

            [ColumnName(@"by_gsm")]
            public float By_gsm { get; set; }

            [ColumnName(@"bz_gsm")]
            public float Bz_gsm { get; set; }

            [ColumnName(@"bt")]
            public float Bt { get; set; }

            [ColumnName(@"intensity")]
            public float Intensity { get; set; }

            [ColumnName(@"declination")]
            public float Declination { get; set; }

            [ColumnName(@"inclination")]
            public float Inclination { get; set; }

            [ColumnName(@"north")]
            public float North { get; set; }

            [ColumnName(@"east")]
            public float East { get; set; }

            [ColumnName(@"vertical")]
            public float Vertical { get; set; }

            [ColumnName(@"horizontal")]
            public float Horizontal { get; set; }

            [ColumnName(@"class")]
            public float Class { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("RssiRegressionEngine.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

    }
}
