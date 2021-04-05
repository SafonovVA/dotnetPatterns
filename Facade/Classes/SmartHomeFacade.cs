using Facade.Classes.Tech;

namespace Facade.Classes
{
    public class SmartHomeFacade
    {
        private readonly Light _light;
        private readonly Garage _garage;
        private readonly Sound _sound;

        public SmartHomeFacade(Light light = null, Garage garage = null, Sound sound = null)
        {
            _light = light ?? new Light();
            _garage = garage ?? new Garage();
            _sound = sound ?? new Sound();
        }

        public void EnableTech()
        {
            _light.On();
            _garage.DoorOpen();
            _sound.Enable();
        }

        public void DisableTech()
        {
            _light.Off();
            _garage.DoorClose();
            _sound.Disable();
        }
        
    }
}