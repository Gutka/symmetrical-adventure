using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 0, "Town square", "I see fountain there!", "/Engine;component/Images/Locations/Fountain.png");
            newWorld.AddLocation(0, -1, "Home", "That is your home!", "/Engine;component/Images/Locations/Home.png");
            newWorld.AddLocation(0, 1, "Fortress", "People here are protecting us!", "/Engine;component/Images/Locations/Fortress.png");
            newWorld.AddLocation(0, 2, "Forest", "Peope are scared of this place!", "/Engine;component/Images/Locations/Forest.png");
            newWorld.AddLocation(-1, -1, "Herbalist", "Helbalist offers everything you want!", "/Engine;component/Images/Locations/Herbalist.png");
            newWorld.AddLocation(-1, 0, "Church", "Holy place!", "/Engine;component/Images/Locations/Church.png");
            newWorld.AddLocation(-2, 0, "Cemetery", "Many dangers are hiding here! Be careful!", "/Engine;component/Images/Locations/Cemetery.png");
            newWorld.AddLocation(1, 0, "Pub", "Place where you can rest and meet people.", "/Engine;component/Images/Locations/Pub.png");
            newWorld.AddLocation(-1, 1, "Field", "Another way how survive!", "/Engine;component/Images/Locations/Field.png");

            return newWorld;
        }
    }
}
