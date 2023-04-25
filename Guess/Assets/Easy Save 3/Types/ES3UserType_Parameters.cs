using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("MuteIcon", "ProgressText", "Progressslider", "QuestionProgressText", "Questionslider", "ActorsPackCorrectAnswers", "AppsPackCorrectAnswers", "CartoonsPackCorrectAnswers", "FamousPackCorrectAnswers", "FlagsPackCorrectAnswers", "LandmarksPackCorrectAnswers", "SoftwaresPackCorrectAnswers", "SuperheroesPackCorrectAnswers", "VehiclesPackCorrectAnswers", "LevelButtonText", "ActorsPackButtonText", "AppsPackButtonText", "CartoonsPackButtonText", "FamousPackButtonText", "FlagsPackButtonText", "LandmarksPackButtonText", "SoftwaresPackButtonText", "SuperheroesPackButtonText", "VehiclesPackButtonText", "ActorsPackBool", "AppsPackBool", "CartoonsPackBool", "FamousPackBool", "FlagsPackBool", "LandmarksPackBool", "SoftwaresPackBool", "SuperheroesPackBool", "VehiclesPackBool", "ActorsPackCheckBool", "AppsPackCheckBool", "CartoonsPackCheckBool", "FamousPackCheckBool", "FlagsPackCheckBool", "LandmarksPackCheckBool", "SoftwaresPackCheckBool", "SuperheroesPackCheckBool", "VehiclesPackCheckBool", "ActorsPackPanelImage", "AppsPackPanelImage", "CartoonsPackPanelImage", "FamousPackPanelImage", "FlagsPackPanelImage", "LandmarksPackPanelImage", "SoftwaresPackPanelImage", "SuperheroesPackPanelImage", "VehiclesPackPanelImage", "CurrentGold", "CurrentScore")]
	public class ES3UserType_Parameters : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_Parameters() : base(typeof(Parameters)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Parameters)obj;
			
			writer.WritePropertyByRef("MuteIcon", instance.MuteIcon);
			writer.WritePropertyByRef("ProgressText", instance.ProgressText);
			writer.WritePropertyByRef("Progressslider", instance.Progressslider);
			writer.WriteProperty("QuestionProgressText", instance.QuestionProgressText, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(TMPro.TextMeshProUGUI[])));
			writer.WriteProperty("Questionslider", instance.Questionslider, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(UnityEngine.UI.Slider[])));
			writer.WriteProperty("ActorsPackCorrectAnswers", instance.ActorsPackCorrectAnswers, ES3Type_intArray.Instance);
			writer.WriteProperty("AppsPackCorrectAnswers", instance.AppsPackCorrectAnswers, ES3Type_intArray.Instance);
			writer.WriteProperty("CartoonsPackCorrectAnswers", instance.CartoonsPackCorrectAnswers, ES3Type_intArray.Instance);
			writer.WriteProperty("FamousPackCorrectAnswers", instance.FamousPackCorrectAnswers, ES3Type_intArray.Instance);
			writer.WriteProperty("FlagsPackCorrectAnswers", instance.FlagsPackCorrectAnswers, ES3Type_intArray.Instance);
			writer.WriteProperty("LandmarksPackCorrectAnswers", instance.LandmarksPackCorrectAnswers, ES3Type_intArray.Instance);
			writer.WriteProperty("SoftwaresPackCorrectAnswers", instance.SoftwaresPackCorrectAnswers, ES3Type_intArray.Instance);
			writer.WriteProperty("SuperheroesPackCorrectAnswers", instance.SuperheroesPackCorrectAnswers, ES3Type_intArray.Instance);
			writer.WriteProperty("VehiclesPackCorrectAnswers", instance.VehiclesPackCorrectAnswers, ES3Type_intArray.Instance);
			writer.WriteProperty("LevelButtonText", instance.LevelButtonText, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(TMPro.TextMeshProUGUI[])));
			writer.WriteProperty("ActorsPackButtonText", instance.ActorsPackButtonText, ES3Type_StringArray.Instance);
			writer.WriteProperty("AppsPackButtonText", instance.AppsPackButtonText, ES3Type_StringArray.Instance);
			writer.WriteProperty("CartoonsPackButtonText", instance.CartoonsPackButtonText, ES3Type_StringArray.Instance);
			writer.WriteProperty("FamousPackButtonText", instance.FamousPackButtonText, ES3Type_StringArray.Instance);
			writer.WriteProperty("FlagsPackButtonText", instance.FlagsPackButtonText, ES3Type_StringArray.Instance);
			writer.WriteProperty("LandmarksPackButtonText", instance.LandmarksPackButtonText, ES3Type_StringArray.Instance);
			writer.WriteProperty("SoftwaresPackButtonText", instance.SoftwaresPackButtonText, ES3Type_StringArray.Instance);
			writer.WriteProperty("SuperheroesPackButtonText", instance.SuperheroesPackButtonText, ES3Type_StringArray.Instance);
			writer.WriteProperty("VehiclesPackButtonText", instance.VehiclesPackButtonText, ES3Type_StringArray.Instance);
			writer.WriteProperty("ActorsPackBool", instance.ActorsPackBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("AppsPackBool", instance.AppsPackBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("CartoonsPackBool", instance.CartoonsPackBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("FamousPackBool", instance.FamousPackBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("FlagsPackBool", instance.FlagsPackBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("LandmarksPackBool", instance.LandmarksPackBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("SoftwaresPackBool", instance.SoftwaresPackBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("SuperheroesPackBool", instance.SuperheroesPackBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("VehiclesPackBool", instance.VehiclesPackBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("ActorsPackCheckBool", instance.ActorsPackCheckBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("AppsPackCheckBool", instance.AppsPackCheckBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("CartoonsPackCheckBool", instance.CartoonsPackCheckBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("FamousPackCheckBool", instance.FamousPackCheckBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("FlagsPackCheckBool", instance.FlagsPackCheckBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("LandmarksPackCheckBool", instance.LandmarksPackCheckBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("SoftwaresPackCheckBool", instance.SoftwaresPackCheckBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("SuperheroesPackCheckBool", instance.SuperheroesPackCheckBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("VehiclesPackCheckBool", instance.VehiclesPackCheckBool, ES3Type_boolArray.Instance);
			writer.WriteProperty("ActorsPackPanelImage", instance.ActorsPackPanelImage, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(UnityEngine.Sprite[])));
			writer.WriteProperty("AppsPackPanelImage", instance.AppsPackPanelImage, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(UnityEngine.Sprite[])));
			writer.WriteProperty("CartoonsPackPanelImage", instance.CartoonsPackPanelImage, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(UnityEngine.Sprite[])));
			writer.WriteProperty("FamousPackPanelImage", instance.FamousPackPanelImage, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(UnityEngine.Sprite[])));
			writer.WriteProperty("FlagsPackPanelImage", instance.FlagsPackPanelImage, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(UnityEngine.Sprite[])));
			writer.WriteProperty("LandmarksPackPanelImage", instance.LandmarksPackPanelImage, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(UnityEngine.Sprite[])));
			writer.WriteProperty("SoftwaresPackPanelImage", instance.SoftwaresPackPanelImage, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(UnityEngine.Sprite[])));
			writer.WriteProperty("SuperheroesPackPanelImage", instance.SuperheroesPackPanelImage, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(UnityEngine.Sprite[])));
			writer.WriteProperty("VehiclesPackPanelImage", instance.VehiclesPackPanelImage, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(UnityEngine.Sprite[])));
			writer.WriteProperty("CurrentGold", instance.CurrentGold, ES3Type_int.Instance);
			writer.WriteProperty("CurrentScore", instance.CurrentScore, ES3Type_int.Instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Parameters)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "MuteIcon":
						instance.MuteIcon = reader.Read<UnityEngine.GameObject>(ES3Type_GameObject.Instance);
						break;
					case "ProgressText":
						instance.ProgressText = reader.Read<TMPro.TextMeshProUGUI>();
						break;
					case "Progressslider":
						instance.Progressslider = reader.Read<UnityEngine.UI.Slider>();
						break;
					case "QuestionProgressText":
						instance.QuestionProgressText = reader.Read<TMPro.TextMeshProUGUI[]>();
						break;
					case "Questionslider":
						instance.Questionslider = reader.Read<UnityEngine.UI.Slider[]>();
						break;
					case "ActorsPackCorrectAnswers":
						instance.ActorsPackCorrectAnswers = reader.Read<System.Int32[]>(ES3Type_intArray.Instance);
						break;
					case "AppsPackCorrectAnswers":
						instance.AppsPackCorrectAnswers = reader.Read<System.Int32[]>(ES3Type_intArray.Instance);
						break;
					case "CartoonsPackCorrectAnswers":
						instance.CartoonsPackCorrectAnswers = reader.Read<System.Int32[]>(ES3Type_intArray.Instance);
						break;
					case "FamousPackCorrectAnswers":
						instance.FamousPackCorrectAnswers = reader.Read<System.Int32[]>(ES3Type_intArray.Instance);
						break;
					case "FlagsPackCorrectAnswers":
						instance.FlagsPackCorrectAnswers = reader.Read<System.Int32[]>(ES3Type_intArray.Instance);
						break;
					case "LandmarksPackCorrectAnswers":
						instance.LandmarksPackCorrectAnswers = reader.Read<System.Int32[]>(ES3Type_intArray.Instance);
						break;
					case "SoftwaresPackCorrectAnswers":
						instance.SoftwaresPackCorrectAnswers = reader.Read<System.Int32[]>(ES3Type_intArray.Instance);
						break;
					case "SuperheroesPackCorrectAnswers":
						instance.SuperheroesPackCorrectAnswers = reader.Read<System.Int32[]>(ES3Type_intArray.Instance);
						break;
					case "VehiclesPackCorrectAnswers":
						instance.VehiclesPackCorrectAnswers = reader.Read<System.Int32[]>(ES3Type_intArray.Instance);
						break;
					case "LevelButtonText":
						instance.LevelButtonText = reader.Read<TMPro.TextMeshProUGUI[]>();
						break;
					case "ActorsPackButtonText":
						instance.ActorsPackButtonText = reader.Read<System.String[]>(ES3Type_StringArray.Instance);
						break;
					case "AppsPackButtonText":
						instance.AppsPackButtonText = reader.Read<System.String[]>(ES3Type_StringArray.Instance);
						break;
					case "CartoonsPackButtonText":
						instance.CartoonsPackButtonText = reader.Read<System.String[]>(ES3Type_StringArray.Instance);
						break;
					case "FamousPackButtonText":
						instance.FamousPackButtonText = reader.Read<System.String[]>(ES3Type_StringArray.Instance);
						break;
					case "FlagsPackButtonText":
						instance.FlagsPackButtonText = reader.Read<System.String[]>(ES3Type_StringArray.Instance);
						break;
					case "LandmarksPackButtonText":
						instance.LandmarksPackButtonText = reader.Read<System.String[]>(ES3Type_StringArray.Instance);
						break;
					case "SoftwaresPackButtonText":
						instance.SoftwaresPackButtonText = reader.Read<System.String[]>(ES3Type_StringArray.Instance);
						break;
					case "SuperheroesPackButtonText":
						instance.SuperheroesPackButtonText = reader.Read<System.String[]>(ES3Type_StringArray.Instance);
						break;
					case "VehiclesPackButtonText":
						instance.VehiclesPackButtonText = reader.Read<System.String[]>(ES3Type_StringArray.Instance);
						break;
					case "ActorsPackBool":
						instance.ActorsPackBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "AppsPackBool":
						instance.AppsPackBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "CartoonsPackBool":
						instance.CartoonsPackBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "FamousPackBool":
						instance.FamousPackBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "FlagsPackBool":
						instance.FlagsPackBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "LandmarksPackBool":
						instance.LandmarksPackBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "SoftwaresPackBool":
						instance.SoftwaresPackBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "SuperheroesPackBool":
						instance.SuperheroesPackBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "VehiclesPackBool":
						instance.VehiclesPackBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "ActorsPackCheckBool":
						instance.ActorsPackCheckBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "AppsPackCheckBool":
						instance.AppsPackCheckBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "CartoonsPackCheckBool":
						instance.CartoonsPackCheckBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "FamousPackCheckBool":
						instance.FamousPackCheckBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "FlagsPackCheckBool":
						instance.FlagsPackCheckBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "LandmarksPackCheckBool":
						instance.LandmarksPackCheckBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "SoftwaresPackCheckBool":
						instance.SoftwaresPackCheckBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "SuperheroesPackCheckBool":
						instance.SuperheroesPackCheckBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "VehiclesPackCheckBool":
						instance.VehiclesPackCheckBool = reader.Read<System.Boolean[]>(ES3Type_boolArray.Instance);
						break;
					case "ActorsPackPanelImage":
						instance.ActorsPackPanelImage = reader.Read<UnityEngine.Sprite[]>();
						break;
					case "AppsPackPanelImage":
						instance.AppsPackPanelImage = reader.Read<UnityEngine.Sprite[]>();
						break;
					case "CartoonsPackPanelImage":
						instance.CartoonsPackPanelImage = reader.Read<UnityEngine.Sprite[]>();
						break;
					case "FamousPackPanelImage":
						instance.FamousPackPanelImage = reader.Read<UnityEngine.Sprite[]>();
						break;
					case "FlagsPackPanelImage":
						instance.FlagsPackPanelImage = reader.Read<UnityEngine.Sprite[]>();
						break;
					case "LandmarksPackPanelImage":
						instance.LandmarksPackPanelImage = reader.Read<UnityEngine.Sprite[]>();
						break;
					case "SoftwaresPackPanelImage":
						instance.SoftwaresPackPanelImage = reader.Read<UnityEngine.Sprite[]>();
						break;
					case "SuperheroesPackPanelImage":
						instance.SuperheroesPackPanelImage = reader.Read<UnityEngine.Sprite[]>();
						break;
					case "VehiclesPackPanelImage":
						instance.VehiclesPackPanelImage = reader.Read<UnityEngine.Sprite[]>();
						break;
					case "CurrentGold":
						instance.CurrentGold = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "CurrentScore":
						instance.CurrentScore = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_ParametersArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_ParametersArray() : base(typeof(Parameters[]), ES3UserType_Parameters.Instance)
		{
			Instance = this;
		}
	}
}