using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern.Example2
{
    public class Profiles : IIterable<string>
    {
        public List<string> profiles { get; private set; }

        public Profiles()
        {
            this.profiles = new List<string>();
        }

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
            return new FriendProfileIterator(this);
        }

        public IProfileIterator<string> CreateCoworkerIterator()
        {
            return new CoworkerProfileIterator(this);
        }

        public class FriendProfileIterator : IProfileIterator<string>
        {
            private Profiles profiles;
            private int index;

            public FriendProfileIterator(Profiles profiles)
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
