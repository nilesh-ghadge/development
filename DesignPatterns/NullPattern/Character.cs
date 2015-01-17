namespace NullPattern
{
    public class Character
    {
        private IWeapon weapon;

        public void SetWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }

        public void Attack()
        {
            weapon.Use();
        }
    }
}
