using Newtonsoft.Json;

namespace WeatherAPI
{
    public class WindInfo
    {
        [JsonProperty("speed")]
        public float Speed;

        [JsonProperty("deg")]
        public float DirectionInDeg;

        public string GetNormalDirectionRU()
        {
            string direction = "";
            int offset = 10;

            int North = 0;
            int East = 90;
            int South = 180;
            int West = 270;

            if (DirectionInDeg > North - offset && DirectionInDeg < North + offset) direction = "Сервер";
            else if (DirectionInDeg > East - offset && DirectionInDeg < East + offset) direction = "Восток";
            else if(DirectionInDeg > South - offset && DirectionInDeg < South + offset) direction = "Юг";
            else if (DirectionInDeg > West - offset && DirectionInDeg < West + offset) direction = "Запад";

            else if (DirectionInDeg > North + offset && DirectionInDeg < East - offset) direction = "Сервер-Восток";
            else if (DirectionInDeg > East + offset && DirectionInDeg < South - offset) direction = "Юго-Восток";
            else if (DirectionInDeg > South + offset && DirectionInDeg < West - offset) direction = "Юго-Запад";
            else if (DirectionInDeg > West + offset && DirectionInDeg < North - offset) direction = "Северо-Запад";

            return direction;

        }

        public string GetNormalDirectionEng()
        {
            string direction = "";
            int offset = 10;

            int North = 0;
            int East = 90;
            int South = 180;
            int West = 270;

            if (DirectionInDeg > North - offset && DirectionInDeg < North + offset) direction = "North";
            else if (DirectionInDeg > East - offset && DirectionInDeg < East + offset) direction = "East";
            else if (DirectionInDeg > South - offset && DirectionInDeg < South + offset) direction = "South";
            else if (DirectionInDeg > West - offset && DirectionInDeg < West + offset) direction = "West";

            else if (DirectionInDeg > North + offset && DirectionInDeg < East - offset) direction = "Northeast";
            else if (DirectionInDeg > East + offset && DirectionInDeg < South - offset) direction = "Southeast";
            else if (DirectionInDeg > South + offset && DirectionInDeg < West - offset) direction = "Southwest";
            else if (DirectionInDeg > West + offset && DirectionInDeg < North - offset) direction = "Northwest";

            return direction;

        }
    }
}
