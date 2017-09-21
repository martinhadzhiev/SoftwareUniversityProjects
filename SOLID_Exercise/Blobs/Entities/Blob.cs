namespace _02.Blobs.Entities
{
    using Interfaces;

    public class Blob
    {
        private int health;
        private IAttack attack;
        private int triggerCount;

        private int initialHealth;
        private int initialDamage;

        public Blob(string name, int health, int damage, IBehavior behavior, IAttack attack)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Behavior = behavior;
            this.attack = attack;

            this.initialHealth = health;
            this.initialDamage = damage;
        }

        public string Name { get; private set; }

        public int Health
        {
            get { return this.health; }
            private set
            {
                this.health = value;

                if (this.health < 0)
                {
                    this.health = 0;
                }

                //if (this.health <= this.initialHealth / 2 && !this.Behavior.IsTriggered)
                //{
                //    this.TriggerBehavior();
                //}
            }
        }

        public IBehavior Behavior { get; private set; }

        public int Damage { get; set; }

        public override string ToString()
        {
            if (this.Health <= 0)
            {
                return $"IBlob {this.Name} KILLED";
            }

            return $"IBlob {this.Name}: {this.Health} HP, {this.Damage} Damage";
        }

    }
}