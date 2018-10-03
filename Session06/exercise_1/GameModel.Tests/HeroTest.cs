using System;
using Xunit;

namespace GameModel.Tests
{
    public class HeroTest
    {
        [Fact]
        public void IsAlive_HitPointsAreAboveZero_ShouldReturnTrue()
        {
            // Arrange 
            var hero = new Hero();
            hero.HitPoints = 1;

            // Act
            var isAlive = hero.IsAlive();

            // Assert
            Assert.True(isAlive);
        }

        [Fact]
        public void IsAlive_HitPointsAreZero_ShouldReturnFalse()
        {
            var hero = new Hero();
            hero.HitPoints = 0;

            var isAlive = hero.IsAlive();

            Assert.False(isAlive);
        }

        [Fact]
        public void IsAlive_HitPointsAreBelowZero_ShouldReturnFalse()
        {
            var hero = new Hero();
            hero.HitPoints = -1;

            var isAlive = hero.IsAlive();

            Assert.False(isAlive);
        }

        [Fact]
        public void Attack_NotAlive_ShouldReturnZero()
        {
            var hero = new Hero();
            hero.HitPoints = -1;

            var attack = hero.Attack();

            Assert.Equal(0, attack);
        }

        [Fact]
        public void Attack_WithoutWeapon_ShouldReturnAttackValueFromStrengthOnly()
        {
            var hero = new Hero();
            hero.Strength = 2;

            var actual = hero.Attack();

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Attack_WithWeaponWithAttackOne_ShouldReturnAttackValue()
        {
            var hero = new Hero();
            var weapon = new Weapon();
            hero.Strength = 2;
            weapon.Attack = 1;
            hero.MainHandWeapon = weapon;

            var actual = hero.Attack();

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Attack_WithWeapon_ShouldReturnAttackValue()
        {
            const int WEAPON_DAMAGE = 42;

            var hero = new Hero();
            var weapon = new Weapon();

            hero.Strength = 1;
            weapon.Attack = WEAPON_DAMAGE;
            hero.MainHandWeapon = weapon;
            var actual = hero.Attack();

            Assert.Equal(WEAPON_DAMAGE / 2, actual);
        }

        [Fact]
        public void Defend_WithDefenceZero_ShouldSubtractFromHitPoints()
        {
            var hero = new Hero();
            var opponent = new Hero();

            hero.Defence = 0;
            hero.HitPoints = 1;
            opponent.Strength = 2;

            hero.Defend(opponent);
            var actual = hero.HitPoints;

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Defend_WithDefenceAboveZero_ShouldSubtractFromHitpoints()
        {
            var hero = new Hero();
            var opponent = new Hero();

            hero.Defence = 1;
            hero.HitPoints = 1;
            opponent.Strength = 2;

            hero.Defend(opponent);
            var actual = hero.HitPoints;

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Defend_IsKilledFromAttack_HitPointsShouldNotGoBelowZero()
        {
            var hero = new Hero();
            var opponent = new Hero();

            hero.Defence = 0;
            hero.HitPoints = 1;
            opponent.Strength = 4;

            hero.Defend(opponent);
            var actual = hero.HitPoints;

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Defend_OpponentIsNull_ShouldThrowArgumentNullException()
        {
            var hero = new Hero();
            Hero opponent = null;

            Action actual = () => hero.Defend(opponent);

            Assert.Throws<ArgumentNullException>(actual);
        }
    }
}