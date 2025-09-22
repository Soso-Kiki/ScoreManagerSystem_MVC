using System;
using UnityEngine;

namespace Feature.ScoreManagement.Data.Model
{
    public class ScoreModel //: //MonoBehaviour
    {
      

        // 실제 점수 값 
        private int _score;

        // 외부에서 점수 값에 접근하고 설정하는 프로퍼티
        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                // 점수 값이 변경되면 OnScoreChanged 이벤트를 호출
                
            }
        }

        public static ScoreModel Initialize()
        {
            return new ScoreModel();
        }
    }
}
