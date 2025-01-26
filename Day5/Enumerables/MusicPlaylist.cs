using System.Collections;
namespace Day5.Enumerables;
public class MusicPlaylist : IEnumerable<Song>
{
    private readonly List<Song> _songs = [];
    public void Add(Song song)
        => _songs.Add(song);
    public void Remove(Song song)
        => _songs.Remove(song);
    public IEnumerator<Song> GetEnumerator()
       => _songs.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
