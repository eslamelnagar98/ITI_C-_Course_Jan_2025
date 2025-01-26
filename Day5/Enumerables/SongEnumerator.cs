using System.Collections;
namespace Day5.Enumerables;
public sealed class SongEnumerator(Song[] songs) : IEnumerator<Song>
{
    private readonly Song[] _songs = songs;

    private int _position = -1;
    public Song Current => ValidateCurrentSong();
    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        if (_position < _songs.Length - 1)
        {
            _position++;
            return true;
        }
        return false;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }


    public void Reset()
    {
        _position = -1;
    }

    private Song ValidateCurrentSong()
    {
        if (_position < 0 || _position >= _songs.Length)
            throw new InvalidOperationException("Enumarator is Out Of Bounds");
        return _songs[_position];
    }

}
