using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour
{
    private bool isPlayerNearby = false;

    // Пример диалога
    private string dialogue = "Привет, путешественник! Как я могу помочь?";
    private GameObject button;
    public DialogWindow WindowPrefab;
    private bool startedDialog;
    private DialogWindow CurrentWindow;

    void Start()
    {
        button = GameObject.FindWithTag("DialogButton");
        button.GetComponent<Button>().onClick.AddListener(StartDialogue);
    }


    private void StartDialogue()
    {
        // Здесь можно добавить код для отображения диалога
        startedDialog = true;
        CurrentWindow = Instantiate(WindowPrefab, button.transform.parent);
        CurrentWindow.SetUpWindow(transform);
        // Например, можно открыть UI для диалога
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Проверяем, что объект с тегом "Player" вошел в триггер
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            button.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Проверяем, что объект с тегом "Player" вышел из триггера
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            button.SetActive(false);
        }
    }
}
