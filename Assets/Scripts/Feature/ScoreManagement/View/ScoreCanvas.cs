using System;
using Common.EventSystem;
using Feature.ScoreManagement.Data.Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Feature.ScoreManagement.View
{
    public struct OnClickScoreAddEvent2 : IEvent
    {
    }

    public class ScoreCanvas : MonoBehaviour, IMonoEventDispatcher
    {
        [SerializeField] private Button addScoreButton;

        private ScoreModel _model;


        private void Awake()
        {
            Debug.Assert(addScoreButton != null, "addScoreButton is not assigned.");
            addScoreButton.onClick.AddListener(this.Emit<OnClickScoreAddEvent2>);
        }

        
    }
}
