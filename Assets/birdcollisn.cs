private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        Debug.Log("Hit: ground");
        GameOver();
    }
    else if (collision.gameObject.CompareTag("Obstacle"))
    {
        Debug.Log("Hit: obstacle");
        GameOver();
    }
}

private void GameOver()
{
    Debug.Log("Game Over");

    Time.timeScale = 0f;
}