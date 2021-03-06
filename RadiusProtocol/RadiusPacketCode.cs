namespace RadiusProtocol
{
    public enum RadiusPacketCode : byte
    {
        AccessRequest = 1,
        AccessAccept = 2,
        AccessReject = 3,
        AccountingRequest = 4,
        AccountingResponse = 5,
        AccountingStatus = 6,
        PasswordRequest = 7,
        PasswordAck = 8,
        PasswordReject = 9,
        AccountingMessage = 10,
        AccessChallenge = 11,
        StatusServer = 12,
        StatusClient = 13,
        ResourceFreeRequest = 21,
        ResourceFreeResponse = 22,
        ResourceQueryRequest = 23,
        ResourceQueryResponse = 24,
        AlternateResourceReclaimRequest = 25,
        NasRebootRequest = 26,
        NasRebootResponse = 27,
        Reserved = 28,
        NextPasscode = 29,
        NewPin = 30,
        TerminateSession = 31,
        PasswordExpired = 32,
        EventRequest = 33,
        EventResponse = 34,
        DisconnectRequest = 40,
        DisconnectAck = 41,
        DisconnectNak = 42,
        CoARequest = 43,
        CoAack = 44,
        CoAnak = 45,
        IpAddressAllocate = 50,
        IpAddressRelease = 51
    }
}