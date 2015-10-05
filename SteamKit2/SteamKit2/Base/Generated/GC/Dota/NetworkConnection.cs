//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: network_connection.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
namespace SteamKit2.GC.Dota.Internal
{
    [global::ProtoBuf.ProtoContract(Name=@"ENetworkDisconnectionReason", EnumPassthru=true)]
    public enum ENetworkDisconnectionReason
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_INVALID", Value=0)]
      NETWORK_DISCONNECT_INVALID = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SHUTDOWN", Value=1)]
      NETWORK_DISCONNECT_SHUTDOWN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DISCONNECT_BY_USER", Value=2)]
      NETWORK_DISCONNECT_DISCONNECT_BY_USER = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DISCONNECT_BY_SERVER", Value=3)]
      NETWORK_DISCONNECT_DISCONNECT_BY_SERVER = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_LOST", Value=4)]
      NETWORK_DISCONNECT_LOST = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_OVERFLOW", Value=5)]
      NETWORK_DISCONNECT_OVERFLOW = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_BANNED", Value=6)]
      NETWORK_DISCONNECT_STEAM_BANNED = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_INUSE", Value=7)]
      NETWORK_DISCONNECT_STEAM_INUSE = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_TICKET", Value=8)]
      NETWORK_DISCONNECT_STEAM_TICKET = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_LOGON", Value=9)]
      NETWORK_DISCONNECT_STEAM_LOGON = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_AUTHCANCELLED", Value=10)]
      NETWORK_DISCONNECT_STEAM_AUTHCANCELLED = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_AUTHALREADYUSED", Value=11)]
      NETWORK_DISCONNECT_STEAM_AUTHALREADYUSED = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_AUTHINVALID", Value=12)]
      NETWORK_DISCONNECT_STEAM_AUTHINVALID = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_VACBANSTATE", Value=13)]
      NETWORK_DISCONNECT_STEAM_VACBANSTATE = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_LOGGED_IN_ELSEWHERE", Value=14)]
      NETWORK_DISCONNECT_STEAM_LOGGED_IN_ELSEWHERE = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_VAC_CHECK_TIMEDOUT", Value=15)]
      NETWORK_DISCONNECT_STEAM_VAC_CHECK_TIMEDOUT = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_DROPPED", Value=16)]
      NETWORK_DISCONNECT_STEAM_DROPPED = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_OWNERSHIP", Value=17)]
      NETWORK_DISCONNECT_STEAM_OWNERSHIP = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SERVERINFO_OVERFLOW", Value=18)]
      NETWORK_DISCONNECT_SERVERINFO_OVERFLOW = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_TICKMSG_OVERFLOW", Value=19)]
      NETWORK_DISCONNECT_TICKMSG_OVERFLOW = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STRINGTABLEMSG_OVERFLOW", Value=20)]
      NETWORK_DISCONNECT_STRINGTABLEMSG_OVERFLOW = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DELTAENTMSG_OVERFLOW", Value=21)]
      NETWORK_DISCONNECT_DELTAENTMSG_OVERFLOW = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_TEMPENTMSG_OVERFLOW", Value=22)]
      NETWORK_DISCONNECT_TEMPENTMSG_OVERFLOW = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SOUNDSMSG_OVERFLOW", Value=23)]
      NETWORK_DISCONNECT_SOUNDSMSG_OVERFLOW = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SNAPSHOTOVERFLOW", Value=24)]
      NETWORK_DISCONNECT_SNAPSHOTOVERFLOW = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SNAPSHOTERROR", Value=25)]
      NETWORK_DISCONNECT_SNAPSHOTERROR = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_RELIABLEOVERFLOW", Value=26)]
      NETWORK_DISCONNECT_RELIABLEOVERFLOW = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_BADDELTATICK", Value=27)]
      NETWORK_DISCONNECT_BADDELTATICK = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_NOMORESPLITS", Value=28)]
      NETWORK_DISCONNECT_NOMORESPLITS = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_TIMEDOUT", Value=29)]
      NETWORK_DISCONNECT_TIMEDOUT = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DISCONNECTED", Value=30)]
      NETWORK_DISCONNECT_DISCONNECTED = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_LEAVINGSPLIT", Value=31)]
      NETWORK_DISCONNECT_LEAVINGSPLIT = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DIFFERENTCLASSTABLES", Value=32)]
      NETWORK_DISCONNECT_DIFFERENTCLASSTABLES = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_BADRELAYPASSWORD", Value=33)]
      NETWORK_DISCONNECT_BADRELAYPASSWORD = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_BADSPECTATORPASSWORD", Value=34)]
      NETWORK_DISCONNECT_BADSPECTATORPASSWORD = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_HLTVRESTRICTED", Value=35)]
      NETWORK_DISCONNECT_HLTVRESTRICTED = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_NOSPECTATORS", Value=36)]
      NETWORK_DISCONNECT_NOSPECTATORS = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_HLTVUNAVAILABLE", Value=37)]
      NETWORK_DISCONNECT_HLTVUNAVAILABLE = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_HLTVSTOP", Value=38)]
      NETWORK_DISCONNECT_HLTVSTOP = 38,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_KICKED", Value=39)]
      NETWORK_DISCONNECT_KICKED = 39,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_BANADDED", Value=40)]
      NETWORK_DISCONNECT_BANADDED = 40,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_KICKBANADDED", Value=41)]
      NETWORK_DISCONNECT_KICKBANADDED = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_HLTVDIRECT", Value=42)]
      NETWORK_DISCONNECT_HLTVDIRECT = 42,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_PURESERVER_CLIENTEXTRA", Value=43)]
      NETWORK_DISCONNECT_PURESERVER_CLIENTEXTRA = 43,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_PURESERVER_MISMATCH", Value=44)]
      NETWORK_DISCONNECT_PURESERVER_MISMATCH = 44,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_USERCMD", Value=45)]
      NETWORK_DISCONNECT_USERCMD = 45,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_REJECTED_BY_GAME", Value=46)]
      NETWORK_DISCONNECT_REJECTED_BY_GAME = 46,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_MESSAGE_PARSE_ERROR", Value=47)]
      NETWORK_DISCONNECT_MESSAGE_PARSE_ERROR = 47,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_INVALID_MESSAGE_ERROR", Value=48)]
      NETWORK_DISCONNECT_INVALID_MESSAGE_ERROR = 48,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_BAD_SERVER_PASSWORD", Value=49)]
      NETWORK_DISCONNECT_BAD_SERVER_PASSWORD = 49,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DIRECT_CONNECT_RESERVATION", Value=50)]
      NETWORK_DISCONNECT_DIRECT_CONNECT_RESERVATION = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_CONNECTION_FAILURE", Value=51)]
      NETWORK_DISCONNECT_CONNECTION_FAILURE = 51,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_NO_PEER_GROUP_HANDLERS", Value=52)]
      NETWORK_DISCONNECT_NO_PEER_GROUP_HANDLERS = 52,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_RECONNECTION", Value=53)]
      NETWORK_DISCONNECT_RECONNECTION = 53,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_LOOPSHUTDOWN", Value=54)]
      NETWORK_DISCONNECT_LOOPSHUTDOWN = 54,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_LOOPDEACTIVATE", Value=55)]
      NETWORK_DISCONNECT_LOOPDEACTIVATE = 55,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_HOST_ENDGAME", Value=56)]
      NETWORK_DISCONNECT_HOST_ENDGAME = 56,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_LOOP_LEVELLOAD_ACTIVATE", Value=57)]
      NETWORK_DISCONNECT_LOOP_LEVELLOAD_ACTIVATE = 57,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_CREATE_SERVER_FAILED", Value=58)]
      NETWORK_DISCONNECT_CREATE_SERVER_FAILED = 58,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_EXITING", Value=59)]
      NETWORK_DISCONNECT_EXITING = 59,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_REQUEST_HOSTSTATE_IDLE", Value=60)]
      NETWORK_DISCONNECT_REQUEST_HOSTSTATE_IDLE = 60,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_REQUEST_HOSTSTATE_HLTVRELAY", Value=61)]
      NETWORK_DISCONNECT_REQUEST_HOSTSTATE_HLTVRELAY = 61,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_CLIENT_CONSISTENCY_FAIL", Value=62)]
      NETWORK_DISCONNECT_CLIENT_CONSISTENCY_FAIL = 62,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_CLIENT_UNABLE_TO_CRC_MAP", Value=63)]
      NETWORK_DISCONNECT_CLIENT_UNABLE_TO_CRC_MAP = 63,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_CLIENT_NO_MAP", Value=64)]
      NETWORK_DISCONNECT_CLIENT_NO_MAP = 64,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_CLIENT_DIFFERENT_MAP", Value=65)]
      NETWORK_DISCONNECT_CLIENT_DIFFERENT_MAP = 65,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SERVER_REQUIRES_STEAM", Value=66)]
      NETWORK_DISCONNECT_SERVER_REQUIRES_STEAM = 66,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_DENY_MISC", Value=67)]
      NETWORK_DISCONNECT_STEAM_DENY_MISC = 67,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_DENY_BAD_ANTI_CHEAT", Value=68)]
      NETWORK_DISCONNECT_STEAM_DENY_BAD_ANTI_CHEAT = 68,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SERVER_SHUTDOWN", Value=69)]
      NETWORK_DISCONNECT_SERVER_SHUTDOWN = 69,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SPLITPACKET_SEND_OVERFLOW", Value=70)]
      NETWORK_DISCONNECT_SPLITPACKET_SEND_OVERFLOW = 70,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_REPLAY_INCOMPATIBLE", Value=71)]
      NETWORK_DISCONNECT_REPLAY_INCOMPATIBLE = 71
    }
  
}
#pragma warning restore 1591
