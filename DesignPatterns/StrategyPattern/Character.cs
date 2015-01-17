namespace StrategyPattern
{
    public class Character
    {
        private IWeapon _weapon;

        public void SetWeapon(IWeapon newWeapon)
        {
            _weapon = newWeapon;
        }

        public void Attack()
        {
            _weapon.Use();
        }
    }
}
