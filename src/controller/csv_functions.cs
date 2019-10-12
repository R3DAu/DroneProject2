using System;
using System.Collections.Generic;
using System.Threading;


namespace DroneProject2.src.controller
{
    /// <summary>
    /// This static class allows the conversion of some enumuerators and control mechanisms.
    /// </summary>
    static class CSVFunctions
    {
        public static float f = 0.25f;
        public static bool dir = true;

        public static Dictionary<string, CSVFunction> CSVStringEnums = new Dictionary<string, CSVFunction>()
        {
            {"SLEEP", CSVFunction.SLEEP},
            {"HOVER", CSVFunction.HOVER},
            {"PITCH", CSVFunction.PITCH},
            {"ROLL", CSVFunction.ROLL},
            {"YAW", CSVFunction.YAW},
            {"LAND", CSVFunction.LAND},
            {"TAKEOFF", CSVFunction.TAKEOFF},
            {"GAZ", CSVFunction.GAZ}
        };

        public static Dictionary<CSVFunction, Action> CSVEnumFunctions = new Dictionary<CSVFunction, Action>()
        {
            {CSVFunction.SLEEP, () => Thread.Sleep(int.Parse(f.ToString()))},
            {CSVFunction.HOVER, DroneController_API.Hover},
            {CSVFunction.PITCH, () => DroneController_API.Pitch(dir, f)},
            {CSVFunction.ROLL, () => DroneController_API.Roll(dir, f)},
            {CSVFunction.YAW, () => DroneController_API.Yaw(dir, f)},
            {CSVFunction.LAND, DroneController_API.Land},
            {CSVFunction.TAKEOFF, DroneController_API.Takeoff},
            {CSVFunction.GAZ, () => DroneController_API.Gaz(dir, f)}
        };
    }
    
    /// <summary>
    /// Control Enumerators for validation.
    /// </summary>
    enum CSVFunction
    {
        NULL    = 0,
        SLEEP   = 1,
        HOVER   = 2,
        PITCH   = 3,
        ROLL    = 4,
        YAW     = 5,
        LAND    = 6,
        TAKEOFF = 7,
        GAZ     = 8
    }

    public struct CSVCMD
    {
        public string Movement;
        public bool Direction;
        public float Float;
    }
}
