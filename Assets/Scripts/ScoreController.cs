using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int _score = 0;

    public void SetScore(int value)
    {
        _score = value;
    }

    public int GetScore()
    {
        return _score;
    }

    public void IncreaseScore(int value)
    {
        _score += value;
    }
}
