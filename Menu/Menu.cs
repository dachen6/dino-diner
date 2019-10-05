using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<IMenuItem> AvailableEntrees { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new DinoNuggets(),
            new PrehistoricPBJ(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap()
        };
        public List<IMenuItem> AvailableSides { get; } = new List<IMenuItem>()
        {
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots(),
        };
        public List<IMenuItem> AvailableDrinks { get; } = new List<IMenuItem>()
        {
            new Sodasaurus(),
            new Tyrannotea(),
            new JurassicJava(),
            new Water(),
        };
        public List<IMenuItem> AvailableCombos { get; } = new List<IMenuItem>()
        {
           new CretaceousCombo ( new Brontowurst()),
           new CretaceousCombo ( new DinoNuggets()),
           new CretaceousCombo ( new PrehistoricPBJ()),
           new CretaceousCombo ( new PterodactylWings()),
           new CretaceousCombo ( new SteakosaurusBurger()),
           new CretaceousCombo ( new TRexKingBurger()),
           new CretaceousCombo ( new VelociWrap())
        };
        public List<IMenuItem> AvailableMenuItems {
            get
        {
            List<IMenuItem> item = new List<IMenuItem>();
            item.AddRange(AvailableCombos);
                item.AddRange(AvailableDrinks);
                item.AddRange(AvailableSides);
                item.AddRange(AvailableEntrees);
                return item;
        }
    }
}
