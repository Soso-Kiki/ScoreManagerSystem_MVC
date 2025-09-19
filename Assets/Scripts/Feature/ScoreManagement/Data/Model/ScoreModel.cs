using System;
using UnityEngine;

namespace Feature.ScoreManagement.Data.Model
{
    public class ScoreModel //: //MonoBehaviour
    {
        // 점수가 변경되었음을 알리는 이벤트
        //public event Action<int> OnScoreChanged;

        // 실제 점수 값 (private으로 보호)
        private int _score;

        // 외부에서 점수 값에 접근하고 설정하는 프로퍼티
        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                // 점수 값이 변경되면 OnScoreChanged 이벤트를 호출하여
                // 구독자(View 등)에게 새로운 점수 값을 알려줍니다.
                //OnScoreChanged?.Invoke(_score);
            }
        }

        public static ScoreModel Initialize()
        {
            return new ScoreModel();
        }
    }
}
