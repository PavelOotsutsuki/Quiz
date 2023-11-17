using UnityEngine;
using System.IO;

public class TestFile
{
    private readonly string _fileName = "questions2.txt";

    private JsonFile _jsonFile;

    public TestFile()
    {
        string fullPath = Application.streamingAssetsPath + "/" + _fileName;
        _jsonFile = JsonUtility.FromJson<JsonFile>(File.ReadAllText(fullPath));
    }

    public bool TryGetRoundData(int roundIndex, out string questionText, out JsonAnswer[] answers, out Sprite background)
    {
        if (IsDataExists(roundIndex))
        {
            JsonRound round = _jsonFile.round[roundIndex];

            questionText = round.question;
            answers = round.answers;

            if (TryLoadImage(round.background, out background) == false)
            {
                Debug.LogError("Error load image");
            }

            return true;
        }

        questionText = default;
        answers = default;
        background = default;

        return false;
    }

    public int GetCountRounds()
    {
        return _jsonFile.round.Length;
    }

    private bool IsDataExists(int index)
    {
        if(index >= _jsonFile.round.Length || index < 0)
        {
            return false;
        }

        return true;
    }

    private bool TryLoadImage(string path, out Sprite sprite)
    {
        string fullPath = Application.streamingAssetsPath + "/" + path;
        byte[] data = File.ReadAllBytes(fullPath);
        Texture2D texture = new Texture2D(64, 64, TextureFormat.ARGB32, false);
        texture.LoadImage(data);
        texture.name = Path.GetFileNameWithoutExtension(fullPath);
        sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);

        return sprite != null;
    }
}