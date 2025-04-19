using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared._Evin.ACVar;

/// <summary>
///     Evin
/// config vars.
/// </summary>
[CVarDefs]
// ReSharper disable once InconsistentNaming
public sealed class ACVars : CVars
{

    /*
     * Discord
     */

    /// <summary>
    /// URL of the discord webhook to relay bans messages.
    /// </summary>
    public static readonly CVarDef<string> DiscordBanWebhook =
        CVarDef.Create("discord.ban_webhook", string.Empty, CVar.SERVERONLY | CVar.CONFIDENTIAL);
}