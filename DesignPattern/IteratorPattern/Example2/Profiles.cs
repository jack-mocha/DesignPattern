using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern.Example2
{
    public class Profiles : IIterable<string>
    {
        private List<string> profiles = new List<string>();
        public void Push(string profile)
        {
            profiles.Add(profile);
        }

        public string Pop()
        {
            var lastIndex = profiles.Count - 1;
            var lastProfile = profiles[lastIndex];
            profiles.RemoveAt(lastIndex);

            return lastProfile;
        }

        public IProfileIterator<string> CreateFriendsIterator()
        {
            return new ProfileIterator(this);
        }

        public IProfileIterator<string> CreaateCoworkerIterator()
        {
            throw new NotImplementedException();
        }

        public class ProfileIterator : IProfileIterator<string>
        {
            private Profiles profiles;
            private int index;

            public ProfileIterator(Profiles profiles)
            {
                this.profiles = profiles;
            }

            public string GetNext()
            {
                return this.profiles.profiles[index++];
            }

            public bool HasMore()
            {
                return index < profiles.profiles.Count;
            }
        }
    }
}
