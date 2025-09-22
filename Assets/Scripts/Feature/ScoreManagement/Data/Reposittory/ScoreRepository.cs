using UnityEngine;

namespace Feature.ScoreManagement.Data.Reposittory
{
    public class ScoreRepository// : MonoBehaviour
    {
        private const string ScoreKey = "PlayerScore"; // 데이터를 저장할 때 사용할 키

        // 점수를 불러오는 함수
        public int LoadScore()
        {
            // PlayerPrefs에서 SCORE_KEY로 저장된 값 불러옴
            return PlayerPrefs.GetInt(ScoreKey, 0);
        }

        // 점수를 저장하는 함수
        public void SaveScore(int score)
        {
            // PlayerPrefs에 점수를 저장합니다.
            PlayerPrefs.SetInt(ScoreKey, score);
            PlayerPrefs.Save(); // 변경사항을 기기에 즉시 저장
        }
    }
}
