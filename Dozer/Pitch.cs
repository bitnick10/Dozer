namespace Dozer
{
    // for piano A#4=1 G#=-1 A5+12 depends on interval in one octave
    // A4 can be 440Hz 442Hz whatever you want this is just steps
    public struct Pitch
    {
        public int delta;
        //0 1  2 3  4 5 6  7 8  9 10 11
        //C C# D D# E F F# G G# A A# B
        public void SetPitch12(int p1, int octave) {
            int deltaToC0 = p1 + octave * 12;
            delta = deltaToC0 + 4 * 12 + 9;
        }
        public string ToString12() {
            string[] part1 =new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};
            int deltaToC0 = delta - 4 * 12 - 9;
            string ret = part1[deltaToC0 % 12];
            ret += (deltaToC0 / 12).ToString();
            return ret;
        }
    }
}
