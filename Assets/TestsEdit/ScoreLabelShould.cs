using NUnit.Framework;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace TestsEdit
{
    public class ScoreLabelShould 
    {
        private GameObject _go;
        private ScoreController _scoreController;

        [SetUp]
        public void Setup()
        {
            _go = new GameObject();
            _scoreController = _go.AddComponent<ScoreController>();
        }
        
        [Test]
        public void ChangeScoreToValue()
        {
            _scoreController.SetScore(500);
            Assert.AreEqual(500, _scoreController.GetScore());
        }

        [Test]
        public void IncreaseScoreByValue()
        {
            _scoreController.SetScore(200);
            _scoreController.IncreaseScore(300);
            
            Assert.AreEqual(500, _scoreController.GetScore());
        }
    }
}
