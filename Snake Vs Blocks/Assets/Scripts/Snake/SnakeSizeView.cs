using TMPro;
using UnityEngine;

[RequireComponent(typeof(Snake))]
public class SnakeSizeView : MonoBehaviour
{
    [SerializeField] private TMP_Text _view;
    private Snake _snake;

    private void Awake()
    {
        _snake = GetComponent<Snake>();
    }

    private void OnEnable()
    {
        _snake.SizeUpdated += OnUpdateSize;
    }

    private void OnDisable()
    {
        _snake.SizeUpdated -= OnUpdateSize;
    }

    private void OnUpdateSize(int size)
    {
        _view.text = size.ToString();
    }
}
