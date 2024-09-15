using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ede
{
    public class ProgressStream : Stream
    {
        private Stream m_input = null;
        private long m_length = 0L;
        private long m_position = 0L;
        public event EventHandler<ProgressEventArgs> UpdateProgress;

        public ProgressStream(Stream input)
        {
            m_input = input;
            m_length = input.Length;
        }
        public override void Flush()
        {
            throw new System.NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new System.NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new System.NotImplementedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long bps;
            int n = m_input.Read(buffer, offset, count);
            try
            {
                bps = (long)(count / sw.Elapsed.TotalSeconds);
            }
            catch (DivideByZeroException)
            {
                bps = int.MaxValue;
            }
            
            sw.Stop();
            
            m_position += n;
            UpdateProgress?.Invoke(this, new ProgressEventArgs((1.0f * m_position) / m_length, bps));
            return n;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new System.NotImplementedException();
        }

        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => m_length;
        public override long Position
        {
            get { return m_position; }
            set { throw new System.NotImplementedException(); }
        }
    }
    public class ProgressEventArgs : EventArgs
    {
        private float m_progress;
        private long m_bps;

        public ProgressEventArgs(float progress, long bps)
        {
            m_progress = progress;
            m_bps = bps;
        }

        public float Progress => m_progress;
        public long BPS => m_bps;
    }
}
