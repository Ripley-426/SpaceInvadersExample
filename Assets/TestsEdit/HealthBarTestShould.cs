using NUnit.Framework;
using UnityEngine;

namespace TestsEdit
{
    public class HealthBarTestShould
    {
        private GameObject _go;
        private HealthController _healthController;

        [SetUp]
        public void Setup()
        {
            _go = new GameObject();
            _healthController = _go.AddComponent<HealthController>();
        }

        [Test]
        public void GivenDamageTheTotalReduces()
        {
            _healthController.DecreaseHealth(15);
            Assert.AreEqual(85, _healthController.GetHealth());
        }

        [Test]
        public void GivenHealTheTotalIncreases()
        {
            _healthController.DecreaseHealth(50);
            _healthController.IncreaseHealth(25);
            Assert.AreEqual(75, _healthController.GetHealth());
        }

        [Test]
        public void HaveADifferentValueWhenChangingTheMax()
        {
            _healthController.SetMaxHealth(200);
            Assert.AreEqual(200, _healthController.GetMaxHealth());
        }
    }
}
