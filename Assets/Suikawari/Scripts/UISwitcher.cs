using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISwitcher : MonoBehaviour
{
    [SerializeField]
    GameObject black, resultPanel, introPanel, dynamicUIs;

    [SerializeField]
    TMPro.TMP_Text scoreText;

    [SerializeField]
    ScoreCalculator calc;

    [SerializeField]
    SuikawariStateManager stateManager;

    public void ToPlayScene()
    {
        stateManager.ToPlaying();
        introPanel.SetActive(false);
    }

    public void ShowResult()
    {
        scoreText.text = $"<color=#B0443A>{calc.CalcScoreData()}</color> 点！（めざせ100万点）";
        black.SetActive(false);
        resultPanel.SetActive(true);

        dynamicUIs.SetActive(false);
    }

    public void Retry()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }
}
