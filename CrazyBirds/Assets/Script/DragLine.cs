using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragLine : MonoBehaviour
{
    LineRenderer _lineRenderer;
    Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _player = FindObjectOfType<Player>();

        Vector3 lineZeroPosition = new Vector3(_player.transform.position.x, _player.transform.position.y, -0.1f);
        _lineRenderer.SetPosition(0, lineZeroPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.IsDragging)
        {
            _lineRenderer.SetPosition(0, _player.transform.position);
            _lineRenderer.enabled = true;
        }
        else
        {
            _lineRenderer.enabled = false;
        }
    }
}
