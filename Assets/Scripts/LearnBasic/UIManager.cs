using UnityEngine;

namespace LearnBasic {
    public class UIManager : MonoBehaviour {
        [SerializeField] private GameObject playBtn = null;
        [SerializeField] private GameObject homeBtn = null;
        [SerializeField] private GameObject homeSqrBtn = null;

        public void OnPlayBtnClick() {
            Debug.Log("Play Button Click found");

            homeSqrBtn.SetActive(true);
            playBtn.SetActive(false);
        }

        public void OnHomeBtnClick() {
            Debug.Log("Home Button Click found");

            playBtn.SetActive(true);
            homeBtn.SetActive(false);
        }

        public void OnHomeSquareBtnClick() {
            homeBtn.SetActive(true);
            homeSqrBtn.SetActive(false);
        }
    }
}
