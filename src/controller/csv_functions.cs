using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneProject2.src.controller
{
    static class CSVFunctions
    {
        static float f = 0.25f;
        static bool dir = true;

        static public Dictionary<string, CSVFunction> CSVStringEnums = new Dictionary<string, CSVFunction>()
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

        static public Dictionary<CSVFunction, Action> CSVEnumFunctions = new Dictionary<CSVFunction, Action>()
        {
            {CSVFunction.SLEEP, DroneController_API.Hover},
            {CSVFunction.HOVER, DroneController_API.Hover},
            {CSVFunction.PITCH, () => DroneController_API.Pitch(dir, f)},
            {CSVFunction.ROLL, () => DroneController_API.Roll(dir, f)},
            {CSVFunction.YAW, () => DroneController_API.Yaw(dir, f)},
            {CSVFunction.LAND, () => DroneController_API.Land()},
            {CSVFunction.TAKEOFF, () => DroneController_API.Takeoff()},
            {CSVFunction.GAZ, () => DroneController_API.Gaz(dir, f)}
        };
    }
    

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

}
