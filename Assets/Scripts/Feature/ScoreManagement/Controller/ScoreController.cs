using Common.EventSystem;
using Feature.ScoreManagement.Data.Model;
using Feature.ScoreManagement.Data.Reposittory;
using Feature.ScoreManagement.View;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Feature.ScoreManagement.Controller
{
    public class ScoreController : MonoBehaviour,IMonoEventListener
    {
        
        private ScoreModel _model;
        private ScoreRepository _repository;
        [SerializeField] private TextMeshProUGUI scoreText;

        private void Awake()
        {
            Debug.Assert(scoreText != null);
            // Model과 Repository 객체를 생성합니다.
            _repository = new ScoreRepository();

            _model = ScoreModel.Initialize();
            // 저장소에서 마지막 점수를 불러와 모델에 설정합니다.
            _model.Score = _repository.LoadScore();
            
            UpdateScoreText(_model.Score);
            // View에게 Model을 알려주어 서로 연결되게 합니다.
            // scoreCanvas.SetModel(_model);
        }



        public EventChain OnEventHandle(IEvent param)
        {
            switch (param)
            {
                case OnClickScoreAddEvent2 :
                    Debug.Log("Add Score");
                    // 1. 모델의 점수를 10점 올립니다.
                    _model.Score += 10;
                
                    // 2. 새로운 점수를 저장소에 저장합니다.
                    _repository.SaveScore(_model.Score);
                    UpdateScoreText(_model.Score);
                    return EventChain.Break;
            }
            return EventChain.Continue;
        }
        
        private void UpdateScoreText(int newScore)
        {
            // 나머지 로직은 동일합니다.
            scoreText.text = $"{newScore}";
        }

    }
}
