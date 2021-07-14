using UnityEngine;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        int positionRow = 2;

        public void MoveUp(float distance)
        {
            if (positionRow >= 6) return;
            transform.position = new Vector2(transform.position.x, transform.position.y + distance * Time.deltaTime);
            positionRow++;
        }

        public void MoveDown(float distance)
        {
            if (positionRow <= 1) return;
            transform.position = new Vector2(transform.position.x, transform.position.y - distance * Time.deltaTime);
            positionRow--;
        }
    }
}
