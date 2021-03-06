// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The primary entity on which the action was done.</para>
    /// </summary>
    public class ContextLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ContextLogInfo> Encoder = new ContextLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ContextLogInfo> Decoder = new ContextLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ContextLogInfo" /> class.</para>
        /// </summary>
        public ContextLogInfo()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TeamMember</para>
        /// </summary>
        public bool IsTeamMember
        {
            get
            {
                return this is TeamMember;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TeamMember, or <c>null</c>.</para>
        /// </summary>
        public TeamMember AsTeamMember
        {
            get
            {
                return this as TeamMember;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NonTeamMember</para>
        /// </summary>
        public bool IsNonTeamMember
        {
            get
            {
                return this is NonTeamMember;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NonTeamMember, or <c>null</c>.</para>
        /// </summary>
        public NonTeamMember AsNonTeamMember
        {
            get
            {
                return this as NonTeamMember;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Anonymous</para>
        /// </summary>
        public bool IsAnonymous
        {
            get
            {
                return this is Anonymous;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Anonymous, or <c>null</c>.</para>
        /// </summary>
        public Anonymous AsAnonymous
        {
            get
            {
                return this as Anonymous;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Team</para>
        /// </summary>
        public bool IsTeam
        {
            get
            {
                return this is Team;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Team, or <c>null</c>.</para>
        /// </summary>
        public Team AsTeam
        {
            get
            {
                return this as Team;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ContextLogInfo" />.</para>
        /// </summary>
        private class ContextLogInfoEncoder : enc.StructEncoder<ContextLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ContextLogInfo value, enc.IJsonWriter writer)
            {
                if (value is TeamMember)
                {
                    WriteProperty(".tag", "team_member", writer, enc.StringEncoder.Instance);
                    TeamMember.Encoder.EncodeFields((TeamMember)value, writer);
                    return;
                }
                if (value is NonTeamMember)
                {
                    WriteProperty(".tag", "non_team_member", writer, enc.StringEncoder.Instance);
                    NonTeamMember.Encoder.EncodeFields((NonTeamMember)value, writer);
                    return;
                }
                if (value is Anonymous)
                {
                    WriteProperty(".tag", "anonymous", writer, enc.StringEncoder.Instance);
                    Anonymous.Encoder.EncodeFields((Anonymous)value, writer);
                    return;
                }
                if (value is Team)
                {
                    WriteProperty(".tag", "team", writer, enc.StringEncoder.Instance);
                    Team.Encoder.EncodeFields((Team)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ContextLogInfo" />.</para>
        /// </summary>
        private class ContextLogInfoDecoder : enc.UnionDecoder<ContextLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ContextLogInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ContextLogInfo Create()
            {
                return new ContextLogInfo();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ContextLogInfo Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "team_member":
                        return TeamMember.Decoder.DecodeFields(reader);
                    case "non_team_member":
                        return NonTeamMember.Decoder.DecodeFields(reader);
                    case "anonymous":
                        return Anonymous.Decoder.DecodeFields(reader);
                    case "team":
                        return Team.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Action was done on behalf of a team member.</para>
        /// </summary>
        public sealed class TeamMember : ContextLogInfo
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TeamMember> Encoder = new TeamMemberEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TeamMember> Decoder = new TeamMemberDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TeamMember" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public TeamMember(TeamMemberLogInfo value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TeamMember" /> class.</para>
            /// </summary>
            private TeamMember()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public TeamMemberLogInfo Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TeamMember" />.</para>
            /// </summary>
            private class TeamMemberEncoder : enc.StructEncoder<TeamMember>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TeamMember value, enc.IJsonWriter writer)
                {
                    WriteProperty("team_member", value.Value, writer, global::Dropbox.Api.TeamLog.TeamMemberLogInfo.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TeamMember" />.</para>
            /// </summary>
            private class TeamMemberDecoder : enc.StructDecoder<TeamMember>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TeamMember" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TeamMember Create()
                {
                    return new TeamMember();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override TeamMember DecodeFields(enc.IJsonReader reader)
                {
                    return new TeamMember(global::Dropbox.Api.TeamLog.TeamMemberLogInfo.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Action was done on behalf of a non team member.</para>
        /// </summary>
        public sealed class NonTeamMember : ContextLogInfo
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NonTeamMember> Encoder = new NonTeamMemberEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NonTeamMember> Decoder = new NonTeamMemberDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NonTeamMember" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public NonTeamMember(NonTeamMemberLogInfo value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NonTeamMember" />
            /// class.</para>
            /// </summary>
            private NonTeamMember()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public NonTeamMemberLogInfo Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NonTeamMember" />.</para>
            /// </summary>
            private class NonTeamMemberEncoder : enc.StructEncoder<NonTeamMember>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NonTeamMember value, enc.IJsonWriter writer)
                {
                    WriteProperty("non_team_member", value.Value, writer, global::Dropbox.Api.TeamLog.NonTeamMemberLogInfo.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NonTeamMember" />.</para>
            /// </summary>
            private class NonTeamMemberDecoder : enc.StructDecoder<NonTeamMember>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NonTeamMember" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NonTeamMember Create()
                {
                    return new NonTeamMember();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NonTeamMember DecodeFields(enc.IJsonReader reader)
                {
                    return new NonTeamMember(global::Dropbox.Api.TeamLog.NonTeamMemberLogInfo.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Anonymous context.</para>
        /// </summary>
        public sealed class Anonymous : ContextLogInfo
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Anonymous> Encoder = new AnonymousEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Anonymous> Decoder = new AnonymousDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Anonymous" /> class.</para>
            /// </summary>
            private Anonymous()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Anonymous</para>
            /// </summary>
            public static readonly Anonymous Instance = new Anonymous();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Anonymous" />.</para>
            /// </summary>
            private class AnonymousEncoder : enc.StructEncoder<Anonymous>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Anonymous value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Anonymous" />.</para>
            /// </summary>
            private class AnonymousDecoder : enc.StructDecoder<Anonymous>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Anonymous" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Anonymous Create()
                {
                    return Anonymous.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Action was done on behalf of the team.</para>
        /// </summary>
        public sealed class Team : ContextLogInfo
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Team> Encoder = new TeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Team> Decoder = new TeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Team" /> class.</para>
            /// </summary>
            private Team()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Team</para>
            /// </summary>
            public static readonly Team Instance = new Team();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Team" />.</para>
            /// </summary>
            private class TeamEncoder : enc.StructEncoder<Team>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Team value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Team" />.</para>
            /// </summary>
            private class TeamDecoder : enc.StructDecoder<Team>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Team" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Team Create()
                {
                    return Team.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ContextLogInfo
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
