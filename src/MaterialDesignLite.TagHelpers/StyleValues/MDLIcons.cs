using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MaterialDesignLite.TagHelpers.StyleValues
{
    public class MDLIcon
    {
        public string Name { get; }
        public string Ligature { get; }
        public string Codepoint { get; }

        public MDLIcon(string name, string ligature, string codepoint)
        {
            Name = name;
            Ligature = ligature;
            Codepoint = codepoint;
        }
    }
    public class MDLIcons
    {

        private static Dictionary<string, MDLIcon> _allIcons = new Dictionary<string, MDLIcon>
        {
            { "3d rotation", new MDLIcon("3d rotation","3d_rotation","E84D")},
{ "accessibility", new MDLIcon("accessibility","accessibility","E84E")},
{ "accessible", new MDLIcon("accessible","accessible","E914")},
{ "account balance", new MDLIcon("account balance","account_balance","E84F")},
{ "account balance wallet", new MDLIcon("account balance wallet","account_balance_wallet","E850")},
{ "account box", new MDLIcon("account box","account_box","E851")},
{ "account circle", new MDLIcon("account circle","account_circle","E853")},
{ "add shopping cart", new MDLIcon("add shopping cart","add_shopping_cart","E854")},
{ "alarm", new MDLIcon("alarm","alarm","E855")},
{ "alarm add", new MDLIcon("alarm add","alarm_add","E856")},
{ "alarm off", new MDLIcon("alarm off","alarm_off","E857")},
{ "alarm on", new MDLIcon("alarm on","alarm_on","E858")},
{ "all out", new MDLIcon("all out","all_out","E90B")},
{ "android", new MDLIcon("android","android","E859")},
{ "announcement", new MDLIcon("announcement","announcement","E85A")},
{ "aspect ratio", new MDLIcon("aspect ratio","aspect_ratio","E85B")},
{ "assessment", new MDLIcon("assessment","assessment","E85C")},
{ "assignment", new MDLIcon("assignment","assignment","E85D")},
{ "assignment ind", new MDLIcon("assignment ind","assignment_ind","E85E")},
{ "assignment late", new MDLIcon("assignment late","assignment_late","E85F")},
{ "assignment return", new MDLIcon("assignment return","assignment_return","E860")},
{ "assignment returned", new MDLIcon("assignment returned","assignment_returned","E861")},
{ "assignment turned in", new MDLIcon("assignment turned in","assignment_turned_in","E862")},
{ "autorenew", new MDLIcon("autorenew","autorenew","E863")},
{ "backup", new MDLIcon("backup","backup","E864")},
{ "book", new MDLIcon("book","book","E865")},
{ "bookmark", new MDLIcon("bookmark","bookmark","E866")},
{ "bookmark border", new MDLIcon("bookmark border","bookmark_border","E867")},
{ "bug report", new MDLIcon("bug report","bug_report","E868")},
{ "build", new MDLIcon("build","build","E869")},
{ "cached", new MDLIcon("cached","cached","E86A")},
{ "camera enhance", new MDLIcon("camera enhance","camera_enhance","E8FC")},
{ "card giftcard", new MDLIcon("card giftcard","card_giftcard","E8F6")},
{ "card membership", new MDLIcon("card membership","card_membership","E8F7")},
{ "card travel", new MDLIcon("card travel","card_travel","E8F8")},
{ "change history", new MDLIcon("change history","change_history","E86B")},
{ "check circle", new MDLIcon("check circle","check_circle","E86C")},
{ "chrome reader mode", new MDLIcon("chrome reader mode","chrome_reader_mode","E86D")},
{ "class", new MDLIcon("class","class","E86E")},
{ "code", new MDLIcon("code","code","E86F")},
{ "compare arrows", new MDLIcon("compare arrows","compare_arrows","E915")},
{ "copyright", new MDLIcon("copyright","copyright","E90C")},
{ "credit card", new MDLIcon("credit card","credit_card","E870")},
{ "dashboard", new MDLIcon("dashboard","dashboard","E871")},
{ "date range", new MDLIcon("date range","date_range","E916")},
{ "delete", new MDLIcon("delete","delete","E872")},
{ "description", new MDLIcon("description","description","E873")},
{ "dns", new MDLIcon("dns","dns","E875")},
{ "done", new MDLIcon("done","done","E876")},
{ "done all", new MDLIcon("done all","done_all","E877")},
{ "donut large", new MDLIcon("donut large","donut_large","E917")},
{ "donut small", new MDLIcon("donut small","donut_small","E918")},
{ "eject", new MDLIcon("eject","eject","E8FB")},
{ "event", new MDLIcon("event","event","E878")},
{ "event seat", new MDLIcon("event seat","event_seat","E903")},
{ "exit to app", new MDLIcon("exit to app","exit_to_app","E879")},
{ "explore", new MDLIcon("explore","explore","E87A")},
{ "extension", new MDLIcon("extension","extension","E87B")},
{ "face", new MDLIcon("face","face","E87C")},
{ "favorite", new MDLIcon("favorite","favorite","E87D")},
{ "favorite border", new MDLIcon("favorite border","favorite_border","E87E")},
{ "feedback", new MDLIcon("feedback","feedback","E87F")},
{ "find in page", new MDLIcon("find in page","find_in_page","E880")},
{ "find replace", new MDLIcon("find replace","find_replace","E881")},
{ "fingerprint", new MDLIcon("fingerprint","fingerprint","E90D")},
{ "flight land", new MDLIcon("flight land","flight_land","E904")},
{ "flight takeoff", new MDLIcon("flight takeoff","flight_takeoff","E905")},
{ "flip to back", new MDLIcon("flip to back","flip_to_back","E882")},
{ "flip to front", new MDLIcon("flip to front","flip_to_front","E883")},
{ "gavel", new MDLIcon("gavel","gavel","E90E")},
{ "get app", new MDLIcon("get app","get_app","E884")},
{ "gif", new MDLIcon("gif","gif","E908")},
{ "grade", new MDLIcon("grade","grade","E885")},
{ "group work", new MDLIcon("group work","group_work","E886")},
{ "help", new MDLIcon("help","help","E887")},
{ "help outline", new MDLIcon("help outline","help_outline","E8FD")},
{ "highlight off", new MDLIcon("highlight off","highlight_off","E888")},
{ "history", new MDLIcon("history","history","E889")},
{ "home", new MDLIcon("home","home","E88A")},
{ "hourglass empty", new MDLIcon("hourglass empty","hourglass_empty","E88B")},
{ "hourglass full", new MDLIcon("hourglass full","hourglass_full","E88C")},
{ "http", new MDLIcon("http","http","E902")},
{ "https", new MDLIcon("https","https","E88D")},
{ "important devices", new MDLIcon("important devices","important_devices","E912")},
{ "info", new MDLIcon("info","info","E88E")},
{ "info outline", new MDLIcon("info outline","info_outline","E88F")},
{ "input", new MDLIcon("input","input","E890")},
{ "invert colors", new MDLIcon("invert colors","invert_colors","E891")},
{ "label", new MDLIcon("label","label","E892")},
{ "label outline", new MDLIcon("label outline","label_outline","E893")},
{ "language", new MDLIcon("language","language","E894")},
{ "launch", new MDLIcon("launch","launch","E895")},
{ "lightbulb outline", new MDLIcon("lightbulb outline","lightbulb_outline","E90F")},
{ "line style", new MDLIcon("line style","line_style","E919")},
{ "line weight", new MDLIcon("line weight","line_weight","E91A")},
{ "list", new MDLIcon("list","list","E896")},
{ "lock", new MDLIcon("lock","lock","E897")},
{ "lock open", new MDLIcon("lock open","lock_open","E898")},
{ "lock outline", new MDLIcon("lock outline","lock_outline","E899")},
{ "loyalty", new MDLIcon("loyalty","loyalty","E89A")},
{ "markunread mailbox", new MDLIcon("markunread mailbox","markunread_mailbox","E89B")},
{ "motorcycle", new MDLIcon("motorcycle","motorcycle","E91B")},
{ "note add", new MDLIcon("note add","note_add","E89C")},
{ "offline pin", new MDLIcon("offline pin","offline_pin","E90A")},
{ "opacity", new MDLIcon("opacity","opacity","E91C")},
{ "open in browser", new MDLIcon("open in browser","open_in_browser","E89D")},
{ "open in new", new MDLIcon("open in new","open_in_new","E89E")},
{ "open with", new MDLIcon("open with","open_with","E89F")},
{ "pageview", new MDLIcon("pageview","pageview","E8A0")},
{ "pan tool", new MDLIcon("pan tool","pan_tool","E925")},
{ "payment", new MDLIcon("payment","payment","E8A1")},
{ "perm camera mic", new MDLIcon("perm camera mic","perm_camera_mic","E8A2")},
{ "perm contact calendar", new MDLIcon("perm contact calendar","perm_contact_calendar","E8A3")},
{ "perm data setting", new MDLIcon("perm data setting","perm_data_setting","E8A4")},
{ "perm device information", new MDLIcon("perm device information","perm_device_information","E8A5")},
{ "perm identity", new MDLIcon("perm identity","perm_identity","E8A6")},
{ "perm media", new MDLIcon("perm media","perm_media","E8A7")},
{ "perm phone msg", new MDLIcon("perm phone msg","perm_phone_msg","E8A8")},
{ "perm scan wifi", new MDLIcon("perm scan wifi","perm_scan_wifi","E8A9")},
{ "pets", new MDLIcon("pets","pets","E91D")},
{ "picture in picture", new MDLIcon("picture in picture","picture_in_picture","E8AA")},
{ "picture in picture alt", new MDLIcon("picture in picture alt","picture_in_picture_alt","E911")},
{ "play for work", new MDLIcon("play for work","play_for_work","E906")},
{ "polymer", new MDLIcon("polymer","polymer","E8AB")},
{ "power settings new", new MDLIcon("power settings new","power_settings_new","E8AC")},
{ "pregnant woman", new MDLIcon("pregnant woman","pregnant_woman","E91E")},
{ "print", new MDLIcon("print","print","E8AD")},
{ "query builder", new MDLIcon("query builder","query_builder","E8AE")},
{ "question answer", new MDLIcon("question answer","question_answer","E8AF")},
{ "receipt", new MDLIcon("receipt","receipt","E8B0")},
{ "record voice over", new MDLIcon("record voice over","record_voice_over","E91F")},
{ "redeem", new MDLIcon("redeem","redeem","E8B1")},
{ "reorder", new MDLIcon("reorder","reorder","E8FE")},
{ "report problem", new MDLIcon("report problem","report_problem","E8B2")},
{ "restore", new MDLIcon("restore","restore","E8B3")},
{ "room", new MDLIcon("room","room","E8B4")},
{ "rounded corner", new MDLIcon("rounded corner","rounded_corner","E920")},
{ "rowing", new MDLIcon("rowing","rowing","E921")},
{ "schedule", new MDLIcon("schedule","schedule","E8B5")},
{ "search", new MDLIcon("search","search","E8B6")},
{ "settings", new MDLIcon("settings","settings","E8B8")},
{ "settings applications", new MDLIcon("settings applications","settings_applications","E8B9")},
{ "settings backup restore", new MDLIcon("settings backup restore","settings_backup_restore","E8BA")},
{ "settings bluetooth", new MDLIcon("settings bluetooth","settings_bluetooth","E8BB")},
{ "settings brightness", new MDLIcon("settings brightness","settings_brightness","E8BD")},
{ "settings cell", new MDLIcon("settings cell","settings_cell","E8BC")},
{ "settings ethernet", new MDLIcon("settings ethernet","settings_ethernet","E8BE")},
{ "settings input antenna", new MDLIcon("settings input antenna","settings_input_antenna","E8BF")},
{ "settings input component", new MDLIcon("settings input component","settings_input_component","E8C0")},
{ "settings input composite", new MDLIcon("settings input composite","settings_input_composite","E8C1")},
{ "settings input hdmi", new MDLIcon("settings input hdmi","settings_input_hdmi","E8C2")},
{ "settings input svideo", new MDLIcon("settings input svideo","settings_input_svideo","E8C3")},
{ "settings overscan", new MDLIcon("settings overscan","settings_overscan","E8C4")},
{ "settings phone", new MDLIcon("settings phone","settings_phone","E8C5")},
{ "settings power", new MDLIcon("settings power","settings_power","E8C6")},
{ "settings remote", new MDLIcon("settings remote","settings_remote","E8C7")},
{ "settings voice", new MDLIcon("settings voice","settings_voice","E8C8")},
{ "shop", new MDLIcon("shop","shop","E8C9")},
{ "shop two", new MDLIcon("shop two","shop_two","E8CA")},
{ "shopping basket", new MDLIcon("shopping basket","shopping_basket","E8CB")},
{ "shopping cart", new MDLIcon("shopping cart","shopping_cart","E8CC")},
{ "speaker notes", new MDLIcon("speaker notes","speaker_notes","E8CD")},
{ "spellcheck", new MDLIcon("spellcheck","spellcheck","E8CE")},
{ "star rate", new MDLIcon("star rate","star_rate","E8CF")},
{ "stars", new MDLIcon("stars","stars","E8D0")},
{ "store", new MDLIcon("store","store","E8D1")},
{ "subject", new MDLIcon("subject","subject","E8D2")},
{ "supervisor account", new MDLIcon("supervisor account","supervisor_account","E8D3")},
{ "swap horiz", new MDLIcon("swap horiz","swap_horiz","E8D4")},
{ "swap vert", new MDLIcon("swap vert","swap_vert","E8D5")},
{ "swap vertical circle", new MDLIcon("swap vertical circle","swap_vertical_circle","E8D6")},
{ "system update alt", new MDLIcon("system update alt","system_update_alt","E8D7")},
{ "tab", new MDLIcon("tab","tab","E8D8")},
{ "tab unselected", new MDLIcon("tab unselected","tab_unselected","E8D9")},
{ "theaters", new MDLIcon("theaters","theaters","E8DA")},
{ "thumb down", new MDLIcon("thumb down","thumb_down","E8DB")},
{ "thumb up", new MDLIcon("thumb up","thumb_up","E8DC")},
{ "thumbs up down", new MDLIcon("thumbs up down","thumbs_up_down","E8DD")},
{ "timeline", new MDLIcon("timeline","timeline","E922")},
{ "toc", new MDLIcon("toc","toc","E8DE")},
{ "today", new MDLIcon("today","today","E8DF")},
{ "toll", new MDLIcon("toll","toll","E8E0")},
{ "touch app", new MDLIcon("touch app","touch_app","E913")},
{ "track changes", new MDLIcon("track changes","track_changes","E8E1")},
{ "translate", new MDLIcon("translate","translate","E8E2")},
{ "trending down", new MDLIcon("trending down","trending_down","E8E3")},
{ "trending flat", new MDLIcon("trending flat","trending_flat","E8E4")},
{ "trending up", new MDLIcon("trending up","trending_up","E8E5")},
{ "turned in", new MDLIcon("turned in","turned_in","E8E6")},
{ "turned in not", new MDLIcon("turned in not","turned_in_not","E8E7")},
{ "update", new MDLIcon("update","update","E923")},
{ "verified user", new MDLIcon("verified user","verified_user","E8E8")},
{ "view agenda", new MDLIcon("view agenda","view_agenda","E8E9")},
{ "view array", new MDLIcon("view array","view_array","E8EA")},
{ "view carousel", new MDLIcon("view carousel","view_carousel","E8EB")},
{ "view column", new MDLIcon("view column","view_column","E8EC")},
{ "view day", new MDLIcon("view day","view_day","E8ED")},
{ "view headline", new MDLIcon("view headline","view_headline","E8EE")},
{ "view list", new MDLIcon("view list","view_list","E8EF")},
{ "view module", new MDLIcon("view module","view_module","E8F0")},
{ "view quilt", new MDLIcon("view quilt","view_quilt","E8F1")},
{ "view stream", new MDLIcon("view stream","view_stream","E8F2")},
{ "view week", new MDLIcon("view week","view_week","E8F3")},
{ "visibility", new MDLIcon("visibility","visibility","E8F4")},
{ "visibility off", new MDLIcon("visibility off","visibility_off","E8F5")},
{ "watch later", new MDLIcon("watch later","watch_later","E924")},
{ "work", new MDLIcon("work","work","E8F9")},
{ "youtube searched for", new MDLIcon("youtube searched for","youtube_searched_for","E8FA")},
{ "zoom in", new MDLIcon("zoom in","zoom_in","E8FF")},
{ "zoom out", new MDLIcon("zoom out","zoom_out","E900")},
{ "add alert", new MDLIcon("add alert","add_alert","E003")},
{ "error", new MDLIcon("error","error","E000")},
{ "error outline", new MDLIcon("error outline","error_outline","E001")},
{ "warning", new MDLIcon("warning","warning","E002")},
{ "add to queue", new MDLIcon("add to queue","add_to_queue","E05C")},
{ "airplay", new MDLIcon("airplay","airplay","E055")},
{ "album", new MDLIcon("album","album","E019")},
{ "art track", new MDLIcon("art track","art_track","E060")},
{ "av timer", new MDLIcon("av timer","av_timer","E01B")},
{ "closed caption", new MDLIcon("closed caption","closed_caption","E01C")},
{ "equalizer", new MDLIcon("equalizer","equalizer","E01D")},
{ "explicit", new MDLIcon("explicit","explicit","E01E")},
{ "fast forward", new MDLIcon("fast forward","fast_forward","E01F")},
{ "fast rewind", new MDLIcon("fast rewind","fast_rewind","E020")},
{ "fiber dvr", new MDLIcon("fiber dvr","fiber_dvr","E05D")},
{ "fiber manual record", new MDLIcon("fiber manual record","fiber_manual_record","E061")},
{ "fiber new", new MDLIcon("fiber new","fiber_new","E05E")},
{ "fiber pin", new MDLIcon("fiber pin","fiber_pin","E06A")},
{ "fiber smart record", new MDLIcon("fiber smart record","fiber_smart_record","E062")},
{ "forward 10", new MDLIcon("forward 10","forward_10","E056")},
{ "forward 30", new MDLIcon("forward 30","forward_30","E057")},
{ "forward 5", new MDLIcon("forward 5","forward_5","E058")},
{ "games", new MDLIcon("games","games","E021")},
{ "hd", new MDLIcon("hd","hd","E052")},
{ "hearing", new MDLIcon("hearing","hearing","E023")},
{ "high quality", new MDLIcon("high quality","high_quality","E024")},
{ "library add", new MDLIcon("library add","library_add","E02E")},
{ "library books", new MDLIcon("library books","library_books","E02F")},
{ "library music", new MDLIcon("library music","library_music","E030")},
{ "loop", new MDLIcon("loop","loop","E028")},
{ "mic", new MDLIcon("mic","mic","E029")},
{ "mic none", new MDLIcon("mic none","mic_none","E02A")},
{ "mic off", new MDLIcon("mic off","mic_off","E02B")},
{ "movie", new MDLIcon("movie","movie","E02C")},
{ "music video", new MDLIcon("music video","music_video","E063")},
{ "new releases", new MDLIcon("new releases","new_releases","E031")},
{ "not interested", new MDLIcon("not interested","not_interested","E033")},
{ "pause", new MDLIcon("pause","pause","E034")},
{ "pause circle filled", new MDLIcon("pause circle filled","pause_circle_filled","E035")},
{ "pause circle outline", new MDLIcon("pause circle outline","pause_circle_outline","E036")},
{ "play arrow", new MDLIcon("play arrow","play_arrow","E037")},
{ "play circle filled", new MDLIcon("play circle filled","play_circle_filled","E038")},
{ "play circle outline", new MDLIcon("play circle outline","play_circle_outline","E039")},
{ "playlist add", new MDLIcon("playlist add","playlist_add","E03B")},
{ "playlist add check", new MDLIcon("playlist add check","playlist_add_check","E065")},
{ "playlist play", new MDLIcon("playlist play","playlist_play","E05F")},
{ "queue", new MDLIcon("queue","queue","E03C")},
{ "queue music", new MDLIcon("queue music","queue_music","E03D")},
{ "queue play next", new MDLIcon("queue play next","queue_play_next","E066")},
{ "radio", new MDLIcon("radio","radio","E03E")},
{ "recent actors", new MDLIcon("recent actors","recent_actors","E03F")},
{ "remove from queue", new MDLIcon("remove from queue","remove_from_queue","E067")},
{ "repeat", new MDLIcon("repeat","repeat","E040")},
{ "repeat one", new MDLIcon("repeat one","repeat_one","E041")},
{ "replay", new MDLIcon("replay","replay","E042")},
{ "replay 10", new MDLIcon("replay 10","replay_10","E059")},
{ "replay 30", new MDLIcon("replay 30","replay_30","E05A")},
{ "replay 5", new MDLIcon("replay 5","replay_5","E05B")},
{ "shuffle", new MDLIcon("shuffle","shuffle","E043")},
{ "skip next", new MDLIcon("skip next","skip_next","E044")},
{ "skip previous", new MDLIcon("skip previous","skip_previous","E045")},
{ "slow motion video", new MDLIcon("slow motion video","slow_motion_video","E068")},
{ "snooze", new MDLIcon("snooze","snooze","E046")},
{ "sort by alpha", new MDLIcon("sort by alpha","sort_by_alpha","E053")},
{ "stop", new MDLIcon("stop","stop","E047")},
{ "subscriptions", new MDLIcon("subscriptions","subscriptions","E064")},
{ "subtitles", new MDLIcon("subtitles","subtitles","E048")},
{ "surround sound", new MDLIcon("surround sound","surround_sound","E049")},
{ "video library", new MDLIcon("video library","video_library","E04A")},
{ "videocam", new MDLIcon("videocam","videocam","E04B")},
{ "videocam off", new MDLIcon("videocam off","videocam_off","E04C")},
{ "volume down", new MDLIcon("volume down","volume_down","E04D")},
{ "volume mute", new MDLIcon("volume mute","volume_mute","E04E")},
{ "volume off", new MDLIcon("volume off","volume_off","E04F")},
{ "volume up", new MDLIcon("volume up","volume_up","E050")},
{ "web", new MDLIcon("web","web","E051")},
{ "web asset", new MDLIcon("web asset","web_asset","E069")},
{ "business", new MDLIcon("business","business","E0AF")},
{ "call", new MDLIcon("call","call","E0B0")},
{ "call end", new MDLIcon("call end","call_end","E0B1")},
{ "call made", new MDLIcon("call made","call_made","E0B2")},
{ "call merge", new MDLIcon("call merge","call_merge","E0B3")},
{ "call missed", new MDLIcon("call missed","call_missed","E0B4")},
{ "call missed outgoing", new MDLIcon("call missed outgoing","call_missed_outgoing","E0E4")},
{ "call received", new MDLIcon("call received","call_received","E0B5")},
{ "call split", new MDLIcon("call split","call_split","E0B6")},
{ "chat", new MDLIcon("chat","chat","E0B7")},
{ "chat bubble", new MDLIcon("chat bubble","chat_bubble","E0CA")},
{ "chat bubble outline", new MDLIcon("chat bubble outline","chat_bubble_outline","E0CB")},
{ "clear all", new MDLIcon("clear all","clear_all","E0B8")},
{ "comment", new MDLIcon("comment","comment","E0B9")},
{ "contact mail", new MDLIcon("contact mail","contact_mail","E0D0")},
{ "contact phone", new MDLIcon("contact phone","contact_phone","E0CF")},
{ "contacts", new MDLIcon("contacts","contacts","E0BA")},
{ "dialer sip", new MDLIcon("dialer sip","dialer_sip","E0BB")},
{ "dialpad", new MDLIcon("dialpad","dialpad","E0BC")},
{ "email", new MDLIcon("email","email","E0BE")},
{ "forum", new MDLIcon("forum","forum","E0BF")},
{ "import contacts", new MDLIcon("import contacts","import_contacts","E0E0")},
{ "import export", new MDLIcon("import export","import_export","E0C3")},
{ "invert colors off", new MDLIcon("invert colors off","invert_colors_off","E0C4")},
{ "live help", new MDLIcon("live help","live_help","E0C6")},
{ "location off", new MDLIcon("location off","location_off","E0C7")},
{ "location on", new MDLIcon("location on","location_on","E0C8")},
{ "mail outline", new MDLIcon("mail outline","mail_outline","E0E1")},
{ "message", new MDLIcon("message","message","E0C9")},
{ "no sim", new MDLIcon("no sim","no_sim","E0CC")},
{ "phone", new MDLIcon("phone","phone","E0CD")},
{ "phonelink erase", new MDLIcon("phonelink erase","phonelink_erase","E0DB")},
{ "phonelink lock", new MDLIcon("phonelink lock","phonelink_lock","E0DC")},
{ "phonelink ring", new MDLIcon("phonelink ring","phonelink_ring","E0DD")},
{ "phonelink setup", new MDLIcon("phonelink setup","phonelink_setup","E0DE")},
{ "portable wifi off", new MDLIcon("portable wifi off","portable_wifi_off","E0CE")},
{ "present to all", new MDLIcon("present to all","present_to_all","E0DF")},
{ "ring volume", new MDLIcon("ring volume","ring_volume","E0D1")},
{ "screen share", new MDLIcon("screen share","screen_share","E0E2")},
{ "speaker phone", new MDLIcon("speaker phone","speaker_phone","E0D2")},
{ "stay current landscape", new MDLIcon("stay current landscape","stay_current_landscape","E0D3")},
{ "stay current portrait", new MDLIcon("stay current portrait","stay_current_portrait","E0D4")},
{ "stay primary landscape", new MDLIcon("stay primary landscape","stay_primary_landscape","E0D5")},
{ "stay primary portrait", new MDLIcon("stay primary portrait","stay_primary_portrait","E0D6")},
{ "stop screen share", new MDLIcon("stop screen share","stop_screen_share","E0E3")},
{ "swap calls", new MDLIcon("swap calls","swap_calls","E0D7")},
{ "textsms", new MDLIcon("textsms","textsms","E0D8")},
{ "voicemail", new MDLIcon("voicemail","voicemail","E0D9")},
{ "vpn key", new MDLIcon("vpn key","vpn_key","E0DA")},
{ "add", new MDLIcon("add","add","E145")},
{ "add box", new MDLIcon("add box","add_box","E146")},
{ "add circle", new MDLIcon("add circle","add_circle","E147")},
{ "add circle outline", new MDLIcon("add circle outline","add_circle_outline","E148")},
{ "archive", new MDLIcon("archive","archive","E149")},
{ "backspace", new MDLIcon("backspace","backspace","E14A")},
{ "block", new MDLIcon("block","block","E14B")},
{ "clear", new MDLIcon("clear","clear","E14C")},
{ "content copy", new MDLIcon("content copy","content_copy","E14D")},
{ "content cut", new MDLIcon("content cut","content_cut","E14E")},
{ "content paste", new MDLIcon("content paste","content_paste","E14F")},
{ "create", new MDLIcon("create","create","E150")},
{ "drafts", new MDLIcon("drafts","drafts","E151")},
{ "filter list", new MDLIcon("filter list","filter_list","E152")},
{ "flag", new MDLIcon("flag","flag","E153")},
{ "font download", new MDLIcon("font download","font_download","E167")},
{ "forward", new MDLIcon("forward","forward","E154")},
{ "gesture", new MDLIcon("gesture","gesture","E155")},
{ "inbox", new MDLIcon("inbox","inbox","E156")},
{ "link", new MDLIcon("link","link","E157")},
{ "mail", new MDLIcon("mail","mail","E158")},
{ "markunread", new MDLIcon("markunread","markunread","E159")},
{ "move to inbox", new MDLIcon("move to inbox","move_to_inbox","E168")},
{ "next week", new MDLIcon("next week","next_week","E16A")},
{ "redo", new MDLIcon("redo","redo","E15A")},
{ "remove", new MDLIcon("remove","remove","E15B")},
{ "remove circle", new MDLIcon("remove circle","remove_circle","E15C")},
{ "remove circle outline", new MDLIcon("remove circle outline","remove_circle_outline","E15D")},
{ "reply", new MDLIcon("reply","reply","E15E")},
{ "reply all", new MDLIcon("reply all","reply_all","E15F")},
{ "report", new MDLIcon("report","report","E160")},
{ "save", new MDLIcon("save","save","E161")},
{ "select all", new MDLIcon("select all","select_all","E162")},
{ "send", new MDLIcon("send","send","E163")},
{ "sort", new MDLIcon("sort","sort","E164")},
{ "text format", new MDLIcon("text format","text_format","E165")},
{ "unarchive", new MDLIcon("unarchive","unarchive","E169")},
{ "undo", new MDLIcon("undo","undo","E166")},
{ "weekend", new MDLIcon("weekend","weekend","E16B")},
{ "access alarm", new MDLIcon("access alarm","access_alarm","E190")},
{ "access alarms", new MDLIcon("access alarms","access_alarms","E191")},
{ "access time", new MDLIcon("access time","access_time","E192")},
{ "add alarm", new MDLIcon("add alarm","add_alarm","E193")},
{ "airplanemode active", new MDLIcon("airplanemode active","airplanemode_active","E195")},
{ "airplanemode inactive", new MDLIcon("airplanemode inactive","airplanemode_inactive","E194")},
{ "battery alert", new MDLIcon("battery alert","battery_alert","E19C")},
{ "battery charging full", new MDLIcon("battery charging full","battery_charging_full","E1A3")},
{ "battery full", new MDLIcon("battery full","battery_full","E1A4")},
{ "battery std", new MDLIcon("battery std","battery_std","E1A5")},
{ "battery unknown", new MDLIcon("battery unknown","battery_unknown","E1A6")},
{ "bluetooth", new MDLIcon("bluetooth","bluetooth","E1A7")},
{ "bluetooth connected", new MDLIcon("bluetooth connected","bluetooth_connected","E1A8")},
{ "bluetooth disabled", new MDLIcon("bluetooth disabled","bluetooth_disabled","E1A9")},
{ "bluetooth searching", new MDLIcon("bluetooth searching","bluetooth_searching","E1AA")},
{ "brightness auto", new MDLIcon("brightness auto","brightness_auto","E1AB")},
{ "brightness high", new MDLIcon("brightness high","brightness_high","E1AC")},
{ "brightness low", new MDLIcon("brightness low","brightness_low","E1AD")},
{ "brightness medium", new MDLIcon("brightness medium","brightness_medium","E1AE")},
{ "data usage", new MDLIcon("data usage","data_usage","E1AF")},
{ "developer mode", new MDLIcon("developer mode","developer_mode","E1B0")},
{ "devices", new MDLIcon("devices","devices","E1B1")},
{ "dvr", new MDLIcon("dvr","dvr","E1B2")},
{ "gps fixed", new MDLIcon("gps fixed","gps_fixed","E1B3")},
{ "gps not fixed", new MDLIcon("gps not fixed","gps_not_fixed","E1B4")},
{ "gps off", new MDLIcon("gps off","gps_off","E1B5")},
{ "graphic eq", new MDLIcon("graphic eq","graphic_eq","E1B8")},
{ "location disabled", new MDLIcon("location disabled","location_disabled","E1B6")},
{ "location searching", new MDLIcon("location searching","location_searching","E1B7")},
{ "network cell", new MDLIcon("network cell","network_cell","E1B9")},
{ "network wifi", new MDLIcon("network wifi","network_wifi","E1BA")},
{ "nfc", new MDLIcon("nfc","nfc","E1BB")},
{ "screen lock landscape", new MDLIcon("screen lock landscape","screen_lock_landscape","E1BE")},
{ "screen lock portrait", new MDLIcon("screen lock portrait","screen_lock_portrait","E1BF")},
{ "screen lock rotation", new MDLIcon("screen lock rotation","screen_lock_rotation","E1C0")},
{ "screen rotation", new MDLIcon("screen rotation","screen_rotation","E1C1")},
{ "sd storage", new MDLIcon("sd storage","sd_storage","E1C2")},
{ "settings system daydream", new MDLIcon("settings system daydream","settings_system_daydream","E1C3")},
{ "signal cellular 4 bar", new MDLIcon("signal cellular 4 bar","signal_cellular_4_bar","E1C8")},
{ "signal cellular connected no internet 4 bar", new MDLIcon("signal cellular connected no internet 4 bar","signal_cellular_connected_no_internet_4_bar","E1CD")},
{ "signal cellular no sim", new MDLIcon("signal cellular no sim","signal_cellular_no_sim","E1CE")},
{ "signal cellular null", new MDLIcon("signal cellular null","signal_cellular_null","E1CF")},
{ "signal cellular off", new MDLIcon("signal cellular off","signal_cellular_off","E1D0")},
{ "signal wifi 4 bar", new MDLIcon("signal wifi 4 bar","signal_wifi_4_bar","E1D8")},
{ "signal wifi 4 bar lock", new MDLIcon("signal wifi 4 bar lock","signal_wifi_4_bar_lock","E1D9")},
{ "signal wifi off", new MDLIcon("signal wifi off","signal_wifi_off","E1DA")},
{ "storage", new MDLIcon("storage","storage","E1DB")},
{ "usb", new MDLIcon("usb","usb","E1E0")},
{ "wallpaper", new MDLIcon("wallpaper","wallpaper","E1BC")},
{ "widgets", new MDLIcon("widgets","widgets","E1BD")},
{ "wifi lock", new MDLIcon("wifi lock","wifi_lock","E1E1")},
{ "wifi tethering", new MDLIcon("wifi tethering","wifi_tethering","E1E2")},
{ "attach file", new MDLIcon("attach file","attach_file","E226")},
{ "attach money", new MDLIcon("attach money","attach_money","E227")},
{ "border all", new MDLIcon("border all","border_all","E228")},
{ "border bottom", new MDLIcon("border bottom","border_bottom","E229")},
{ "border clear", new MDLIcon("border clear","border_clear","E22A")},
{ "border color", new MDLIcon("border color","border_color","E22B")},
{ "border horizontal", new MDLIcon("border horizontal","border_horizontal","E22C")},
{ "border inner", new MDLIcon("border inner","border_inner","E22D")},
{ "border left", new MDLIcon("border left","border_left","E22E")},
{ "border outer", new MDLIcon("border outer","border_outer","E22F")},
{ "border right", new MDLIcon("border right","border_right","E230")},
{ "border style", new MDLIcon("border style","border_style","E231")},
{ "border top", new MDLIcon("border top","border_top","E232")},
{ "border vertical", new MDLIcon("border vertical","border_vertical","E233")},
{ "drag handle", new MDLIcon("drag handle","drag_handle","E25D")},
{ "format align center", new MDLIcon("format align center","format_align_center","E234")},
{ "format align justify", new MDLIcon("format align justify","format_align_justify","E235")},
{ "format align left", new MDLIcon("format align left","format_align_left","E236")},
{ "format align right", new MDLIcon("format align right","format_align_right","E237")},
{ "format bold", new MDLIcon("format bold","format_bold","E238")},
{ "format clear", new MDLIcon("format clear","format_clear","E239")},
{ "format color fill", new MDLIcon("format color fill","format_color_fill","E23A")},
{ "format color reset", new MDLIcon("format color reset","format_color_reset","E23B")},
{ "format color text", new MDLIcon("format color text","format_color_text","E23C")},
{ "format indent decrease", new MDLIcon("format indent decrease","format_indent_decrease","E23D")},
{ "format indent increase", new MDLIcon("format indent increase","format_indent_increase","E23E")},
{ "format italic", new MDLIcon("format italic","format_italic","E23F")},
{ "format line spacing", new MDLIcon("format line spacing","format_line_spacing","E240")},
{ "format list bulleted", new MDLIcon("format list bulleted","format_list_bulleted","E241")},
{ "format list numbered", new MDLIcon("format list numbered","format_list_numbered","E242")},
{ "format paint", new MDLIcon("format paint","format_paint","E243")},
{ "format quote", new MDLIcon("format quote","format_quote","E244")},
{ "format shapes", new MDLIcon("format shapes","format_shapes","E25E")},
{ "format size", new MDLIcon("format size","format_size","E245")},
{ "format strikethrough", new MDLIcon("format strikethrough","format_strikethrough","E246")},
{ "format textdirection l to r", new MDLIcon("format textdirection l to r","format_textdirection_l_to_r","E247")},
{ "format textdirection r to l", new MDLIcon("format textdirection r to l","format_textdirection_r_to_l","E248")},
{ "format underlined", new MDLIcon("format underlined","format_underlined","E249")},
{ "functions", new MDLIcon("functions","functions","E24A")},
{ "highlight", new MDLIcon("highlight","highlight","E25F")},
{ "insert chart", new MDLIcon("insert chart","insert_chart","E24B")},
{ "insert comment", new MDLIcon("insert comment","insert_comment","E24C")},
{ "insert drive file", new MDLIcon("insert drive file","insert_drive_file","E24D")},
{ "insert emoticon", new MDLIcon("insert emoticon","insert_emoticon","E24E")},
{ "insert invitation", new MDLIcon("insert invitation","insert_invitation","E24F")},
{ "insert link", new MDLIcon("insert link","insert_link","E250")},
{ "insert photo", new MDLIcon("insert photo","insert_photo","E251")},
{ "linear scale", new MDLIcon("linear scale","linear_scale","E260")},
{ "merge type", new MDLIcon("merge type","merge_type","E252")},
{ "mode comment", new MDLIcon("mode comment","mode_comment","E253")},
{ "mode edit", new MDLIcon("mode edit","mode_edit","E254")},
{ "money off", new MDLIcon("money off","money_off","E25C")},
{ "publish", new MDLIcon("publish","publish","E255")},
{ "short text", new MDLIcon("short text","short_text","E261")},
{ "space bar", new MDLIcon("space bar","space_bar","E256")},
{ "strikethrough s", new MDLIcon("strikethrough s","strikethrough_s","E257")},
{ "text fields", new MDLIcon("text fields","text_fields","E262")},
{ "vertical align bottom", new MDLIcon("vertical align bottom","vertical_align_bottom","E258")},
{ "vertical align center", new MDLIcon("vertical align center","vertical_align_center","E259")},
{ "vertical align top", new MDLIcon("vertical align top","vertical_align_top","E25A")},
{ "wrap text", new MDLIcon("wrap text","wrap_text","E25B")},
{ "attachment", new MDLIcon("attachment","attachment","E2BC")},
{ "cloud", new MDLIcon("cloud","cloud","E2BD")},
{ "cloud circle", new MDLIcon("cloud circle","cloud_circle","E2BE")},
{ "cloud done", new MDLIcon("cloud done","cloud_done","E2BF")},
{ "cloud download", new MDLIcon("cloud download","cloud_download","E2C0")},
{ "cloud off", new MDLIcon("cloud off","cloud_off","E2C1")},
{ "cloud queue", new MDLIcon("cloud queue","cloud_queue","E2C2")},
{ "cloud upload", new MDLIcon("cloud upload","cloud_upload","E2C3")},
{ "create new folder", new MDLIcon("create new folder","create_new_folder","E2CC")},
{ "file download", new MDLIcon("file download","file_download","E2C4")},
{ "file upload", new MDLIcon("file upload","file_upload","E2C6")},
{ "folder", new MDLIcon("folder","folder","E2C7")},
{ "folder open", new MDLIcon("folder open","folder_open","E2C8")},
{ "folder shared", new MDLIcon("folder shared","folder_shared","E2C9")},
{ "cast", new MDLIcon("cast","cast","E307")},
{ "cast connected", new MDLIcon("cast connected","cast_connected","E308")},
{ "computer", new MDLIcon("computer","computer","E30A")},
{ "desktop mac", new MDLIcon("desktop mac","desktop_mac","E30B")},
{ "desktop windows", new MDLIcon("desktop windows","desktop_windows","E30C")},
{ "developer board", new MDLIcon("developer board","developer_board","E30D")},
{ "device hub", new MDLIcon("device hub","device_hub","E335")},
{ "devices other", new MDLIcon("devices other","devices_other","E337")},
{ "dock", new MDLIcon("dock","dock","E30E")},
{ "gamepad", new MDLIcon("gamepad","gamepad","E30F")},
{ "headset", new MDLIcon("headset","headset","E310")},
{ "headset mic", new MDLIcon("headset mic","headset_mic","E311")},
{ "keyboard", new MDLIcon("keyboard","keyboard","E312")},
{ "keyboard arrow down", new MDLIcon("keyboard arrow down","keyboard_arrow_down","E313")},
{ "keyboard arrow left", new MDLIcon("keyboard arrow left","keyboard_arrow_left","E314")},
{ "keyboard arrow right", new MDLIcon("keyboard arrow right","keyboard_arrow_right","E315")},
{ "keyboard arrow up", new MDLIcon("keyboard arrow up","keyboard_arrow_up","E316")},
{ "keyboard backspace", new MDLIcon("keyboard backspace","keyboard_backspace","E317")},
{ "keyboard capslock", new MDLIcon("keyboard capslock","keyboard_capslock","E318")},
{ "keyboard hide", new MDLIcon("keyboard hide","keyboard_hide","E31A")},
{ "keyboard return", new MDLIcon("keyboard return","keyboard_return","E31B")},
{ "keyboard tab", new MDLIcon("keyboard tab","keyboard_tab","E31C")},
{ "keyboard voice", new MDLIcon("keyboard voice","keyboard_voice","E31D")},
{ "laptop", new MDLIcon("laptop","laptop","E31E")},
{ "laptop chromebook", new MDLIcon("laptop chromebook","laptop_chromebook","E31F")},
{ "laptop mac", new MDLIcon("laptop mac","laptop_mac","E320")},
{ "laptop windows", new MDLIcon("laptop windows","laptop_windows","E321")},
{ "memory", new MDLIcon("memory","memory","E322")},
{ "mouse", new MDLIcon("mouse","mouse","E323")},
{ "phone android", new MDLIcon("phone android","phone_android","E324")},
{ "phone iphone", new MDLIcon("phone iphone","phone_iphone","E325")},
{ "phonelink", new MDLIcon("phonelink","phonelink","E326")},
{ "phonelink off", new MDLIcon("phonelink off","phonelink_off","E327")},
{ "power input", new MDLIcon("power input","power_input","E336")},
{ "router", new MDLIcon("router","router","E328")},
{ "scanner", new MDLIcon("scanner","scanner","E329")},
{ "security", new MDLIcon("security","security","E32A")},
{ "sim card", new MDLIcon("sim card","sim_card","E32B")},
{ "smartphone", new MDLIcon("smartphone","smartphone","E32C")},
{ "speaker", new MDLIcon("speaker","speaker","E32D")},
{ "speaker group", new MDLIcon("speaker group","speaker_group","E32E")},
{ "tablet", new MDLIcon("tablet","tablet","E32F")},
{ "tablet android", new MDLIcon("tablet android","tablet_android","E330")},
{ "tablet mac", new MDLIcon("tablet mac","tablet_mac","E331")},
{ "toys", new MDLIcon("toys","toys","E332")},
{ "tv", new MDLIcon("tv","tv","E333")},
{ "videogame asset", new MDLIcon("videogame asset","videogame_asset","E338")},
{ "watch", new MDLIcon("watch","watch","E334")},
{ "add a photo", new MDLIcon("add a photo","add_a_photo","E439")},
{ "add to photos", new MDLIcon("add to photos","add_to_photos","E39D")},
{ "adjust", new MDLIcon("adjust","adjust","E39E")},
{ "assistant", new MDLIcon("assistant","assistant","E39F")},
{ "assistant photo", new MDLIcon("assistant photo","assistant_photo","E3A0")},
{ "audiotrack", new MDLIcon("audiotrack","audiotrack","E3A1")},
{ "blur circular", new MDLIcon("blur circular","blur_circular","E3A2")},
{ "blur linear", new MDLIcon("blur linear","blur_linear","E3A3")},
{ "blur off", new MDLIcon("blur off","blur_off","E3A4")},
{ "blur on", new MDLIcon("blur on","blur_on","E3A5")},
{ "brightness 1", new MDLIcon("brightness 1","brightness_1","E3A6")},
{ "brightness 2", new MDLIcon("brightness 2","brightness_2","E3A7")},
{ "brightness 3", new MDLIcon("brightness 3","brightness_3","E3A8")},
{ "brightness 4", new MDLIcon("brightness 4","brightness_4","E3A9")},
{ "brightness 5", new MDLIcon("brightness 5","brightness_5","E3AA")},
{ "brightness 6", new MDLIcon("brightness 6","brightness_6","E3AB")},
{ "brightness 7", new MDLIcon("brightness 7","brightness_7","E3AC")},
{ "broken image", new MDLIcon("broken image","broken_image","E3AD")},
{ "brush", new MDLIcon("brush","brush","E3AE")},
{ "camera", new MDLIcon("camera","camera","E3AF")},
{ "camera alt", new MDLIcon("camera alt","camera_alt","E3B0")},
{ "camera front", new MDLIcon("camera front","camera_front","E3B1")},
{ "camera rear", new MDLIcon("camera rear","camera_rear","E3B2")},
{ "camera roll", new MDLIcon("camera roll","camera_roll","E3B3")},
{ "center focus strong", new MDLIcon("center focus strong","center_focus_strong","E3B4")},
{ "center focus weak", new MDLIcon("center focus weak","center_focus_weak","E3B5")},
{ "collections", new MDLIcon("collections","collections","E3B6")},
{ "collections bookmark", new MDLIcon("collections bookmark","collections_bookmark","E431")},
{ "color lens", new MDLIcon("color lens","color_lens","E3B7")},
{ "colorize", new MDLIcon("colorize","colorize","E3B8")},
{ "compare", new MDLIcon("compare","compare","E3B9")},
{ "control point", new MDLIcon("control point","control_point","E3BA")},
{ "control point duplicate", new MDLIcon("control point duplicate","control_point_duplicate","E3BB")},
{ "crop", new MDLIcon("crop","crop","E3BE")},
{ "crop 16 9", new MDLIcon("crop 16 9","crop_16_9","E3BC")},
{ "crop 3 2", new MDLIcon("crop 3 2","crop_3_2","E3BD")},
{ "crop 5 4", new MDLIcon("crop 5 4","crop_5_4","E3BF")},
{ "crop 7 5", new MDLIcon("crop 7 5","crop_7_5","E3C0")},
{ "crop din", new MDLIcon("crop din","crop_din","E3C1")},
{ "crop free", new MDLIcon("crop free","crop_free","E3C2")},
{ "crop landscape", new MDLIcon("crop landscape","crop_landscape","E3C3")},
{ "crop original", new MDLIcon("crop original","crop_original","E3C4")},
{ "crop portrait", new MDLIcon("crop portrait","crop_portrait","E3C5")},
{ "crop rotate", new MDLIcon("crop rotate","crop_rotate","E437")},
{ "crop square", new MDLIcon("crop square","crop_square","E3C6")},
{ "dehaze", new MDLIcon("dehaze","dehaze","E3C7")},
{ "details", new MDLIcon("details","details","E3C8")},
{ "edit", new MDLIcon("edit","edit","E3C9")},
{ "exposure", new MDLIcon("exposure","exposure","E3CA")},
{ "exposure neg 1", new MDLIcon("exposure neg 1","exposure_neg_1","E3CB")},
{ "exposure neg 2", new MDLIcon("exposure neg 2","exposure_neg_2","E3CC")},
{ "exposure plus 1", new MDLIcon("exposure plus 1","exposure_plus_1","E3CD")},
{ "exposure plus 2", new MDLIcon("exposure plus 2","exposure_plus_2","E3CE")},
{ "exposure zero", new MDLIcon("exposure zero","exposure_zero","E3CF")},
{ "filter", new MDLIcon("filter","filter","E3D3")},
{ "filter 1", new MDLIcon("filter 1","filter_1","E3D0")},
{ "filter 2", new MDLIcon("filter 2","filter_2","E3D1")},
{ "filter 3", new MDLIcon("filter 3","filter_3","E3D2")},
{ "filter 4", new MDLIcon("filter 4","filter_4","E3D4")},
{ "filter 5", new MDLIcon("filter 5","filter_5","E3D5")},
{ "filter 6", new MDLIcon("filter 6","filter_6","E3D6")},
{ "filter 7", new MDLIcon("filter 7","filter_7","E3D7")},
{ "filter 8", new MDLIcon("filter 8","filter_8","E3D8")},
{ "filter 9", new MDLIcon("filter 9","filter_9","E3D9")},
{ "filter 9 plus", new MDLIcon("filter 9 plus","filter_9_plus","E3DA")},
{ "filter b and w", new MDLIcon("filter b and w","filter_b_and_w","E3DB")},
{ "filter center focus", new MDLIcon("filter center focus","filter_center_focus","E3DC")},
{ "filter drama", new MDLIcon("filter drama","filter_drama","E3DD")},
{ "filter frames", new MDLIcon("filter frames","filter_frames","E3DE")},
{ "filter hdr", new MDLIcon("filter hdr","filter_hdr","E3DF")},
{ "filter none", new MDLIcon("filter none","filter_none","E3E0")},
{ "filter tilt shift", new MDLIcon("filter tilt shift","filter_tilt_shift","E3E2")},
{ "filter vintage", new MDLIcon("filter vintage","filter_vintage","E3E3")},
{ "flare", new MDLIcon("flare","flare","E3E4")},
{ "flash auto", new MDLIcon("flash auto","flash_auto","E3E5")},
{ "flash off", new MDLIcon("flash off","flash_off","E3E6")},
{ "flash on", new MDLIcon("flash on","flash_on","E3E7")},
{ "flip", new MDLIcon("flip","flip","E3E8")},
{ "gradient", new MDLIcon("gradient","gradient","E3E9")},
{ "grain", new MDLIcon("grain","grain","E3EA")},
{ "grid off", new MDLIcon("grid off","grid_off","E3EB")},
{ "grid on", new MDLIcon("grid on","grid_on","E3EC")},
{ "hdr off", new MDLIcon("hdr off","hdr_off","E3ED")},
{ "hdr on", new MDLIcon("hdr on","hdr_on","E3EE")},
{ "hdr strong", new MDLIcon("hdr strong","hdr_strong","E3F1")},
{ "hdr weak", new MDLIcon("hdr weak","hdr_weak","E3F2")},
{ "healing", new MDLIcon("healing","healing","E3F3")},
{ "image", new MDLIcon("image","image","E3F4")},
{ "image aspect ratio", new MDLIcon("image aspect ratio","image_aspect_ratio","E3F5")},
{ "iso", new MDLIcon("iso","iso","E3F6")},
{ "landscape", new MDLIcon("landscape","landscape","E3F7")},
{ "leak add", new MDLIcon("leak add","leak_add","E3F8")},
{ "leak remove", new MDLIcon("leak remove","leak_remove","E3F9")},
{ "lens", new MDLIcon("lens","lens","E3FA")},
{ "linked camera", new MDLIcon("linked camera","linked_camera","E438")},
{ "looks", new MDLIcon("looks","looks","E3FC")},
{ "looks 3", new MDLIcon("looks 3","looks_3","E3FB")},
{ "looks 4", new MDLIcon("looks 4","looks_4","E3FD")},
{ "looks 5", new MDLIcon("looks 5","looks_5","E3FE")},
{ "looks 6", new MDLIcon("looks 6","looks_6","E3FF")},
{ "looks one", new MDLIcon("looks one","looks_one","E400")},
{ "looks two", new MDLIcon("looks two","looks_two","E401")},
{ "loupe", new MDLIcon("loupe","loupe","E402")},
{ "monochrome photos", new MDLIcon("monochrome photos","monochrome_photos","E403")},
{ "movie creation", new MDLIcon("movie creation","movie_creation","E404")},
{ "movie filter", new MDLIcon("movie filter","movie_filter","E43A")},
{ "music note", new MDLIcon("music note","music_note","E405")},
{ "nature", new MDLIcon("nature","nature","E406")},
{ "nature people", new MDLIcon("nature people","nature_people","E407")},
{ "navigate before", new MDLIcon("navigate before","navigate_before","E408")},
{ "navigate next", new MDLIcon("navigate next","navigate_next","E409")},
{ "palette", new MDLIcon("palette","palette","E40A")},
{ "panorama", new MDLIcon("panorama","panorama","E40B")},
{ "panorama fish eye", new MDLIcon("panorama fish eye","panorama_fish_eye","E40C")},
{ "panorama horizontal", new MDLIcon("panorama horizontal","panorama_horizontal","E40D")},
{ "panorama vertical", new MDLIcon("panorama vertical","panorama_vertical","E40E")},
{ "panorama wide angle", new MDLIcon("panorama wide angle","panorama_wide_angle","E40F")},
{ "photo", new MDLIcon("photo","photo","E410")},
{ "photo album", new MDLIcon("photo album","photo_album","E411")},
{ "photo camera", new MDLIcon("photo camera","photo_camera","E412")},
{ "photo filter", new MDLIcon("photo filter","photo_filter","E43B")},
{ "photo library", new MDLIcon("photo library","photo_library","E413")},
{ "photo size select actual", new MDLIcon("photo size select actual","photo_size_select_actual","E432")},
{ "photo size select large", new MDLIcon("photo size select large","photo_size_select_large","E433")},
{ "photo size select small", new MDLIcon("photo size select small","photo_size_select_small","E434")},
{ "picture as pdf", new MDLIcon("picture as pdf","picture_as_pdf","E415")},
{ "portrait", new MDLIcon("portrait","portrait","E416")},
{ "remove red eye", new MDLIcon("remove red eye","remove_red_eye","E417")},
{ "rotate 90 degrees ccw", new MDLIcon("rotate 90 degrees ccw","rotate_90_degrees_ccw","E418")},
{ "rotate left", new MDLIcon("rotate left","rotate_left","E419")},
{ "rotate right", new MDLIcon("rotate right","rotate_right","E41A")},
{ "slideshow", new MDLIcon("slideshow","slideshow","E41B")},
{ "straighten", new MDLIcon("straighten","straighten","E41C")},
{ "style", new MDLIcon("style","style","E41D")},
{ "switch camera", new MDLIcon("switch camera","switch_camera","E41E")},
{ "switch video", new MDLIcon("switch video","switch_video","E41F")},
{ "tag faces", new MDLIcon("tag faces","tag_faces","E420")},
{ "texture", new MDLIcon("texture","texture","E421")},
{ "timelapse", new MDLIcon("timelapse","timelapse","E422")},
{ "timer", new MDLIcon("timer","timer","E425")},
{ "timer 10", new MDLIcon("timer 10","timer_10","E423")},
{ "timer 3", new MDLIcon("timer 3","timer_3","E424")},
{ "timer off", new MDLIcon("timer off","timer_off","E426")},
{ "tonality", new MDLIcon("tonality","tonality","E427")},
{ "transform", new MDLIcon("transform","transform","E428")},
{ "tune", new MDLIcon("tune","tune","E429")},
{ "view comfy", new MDLIcon("view comfy","view_comfy","E42A")},
{ "view compact", new MDLIcon("view compact","view_compact","E42B")},
{ "vignette", new MDLIcon("vignette","vignette","E435")},
{ "wb auto", new MDLIcon("wb auto","wb_auto","E42C")},
{ "wb cloudy", new MDLIcon("wb cloudy","wb_cloudy","E42D")},
{ "wb incandescent", new MDLIcon("wb incandescent","wb_incandescent","E42E")},
{ "wb iridescent", new MDLIcon("wb iridescent","wb_iridescent","E436")},
{ "wb sunny", new MDLIcon("wb sunny","wb_sunny","E430")},
{ "add location", new MDLIcon("add location","add_location","E567")},
{ "beenhere", new MDLIcon("beenhere","beenhere","E52D")},
{ "directions", new MDLIcon("directions","directions","E52E")},
{ "directions bike", new MDLIcon("directions bike","directions_bike","E52F")},
{ "directions boat", new MDLIcon("directions boat","directions_boat","E532")},
{ "directions bus", new MDLIcon("directions bus","directions_bus","E530")},
{ "directions car", new MDLIcon("directions car","directions_car","E531")},
{ "directions railway", new MDLIcon("directions railway","directions_railway","E534")},
{ "directions run", new MDLIcon("directions run","directions_run","E566")},
{ "directions subway", new MDLIcon("directions subway","directions_subway","E533")},
{ "directions transit", new MDLIcon("directions transit","directions_transit","E535")},
{ "directions walk", new MDLIcon("directions walk","directions_walk","E536")},
{ "edit location", new MDLIcon("edit location","edit_location","E568")},
{ "flight", new MDLIcon("flight","flight","E539")},
{ "hotel", new MDLIcon("hotel","hotel","E53A")},
{ "layers", new MDLIcon("layers","layers","E53B")},
{ "layers clear", new MDLIcon("layers clear","layers_clear","E53C")},
{ "local activity", new MDLIcon("local activity","local_activity","E53F")},
{ "local airport", new MDLIcon("local airport","local_airport","E53D")},
{ "local atm", new MDLIcon("local atm","local_atm","E53E")},
{ "local bar", new MDLIcon("local bar","local_bar","E540")},
{ "local cafe", new MDLIcon("local cafe","local_cafe","E541")},
{ "local car wash", new MDLIcon("local car wash","local_car_wash","E542")},
{ "local convenience store", new MDLIcon("local convenience store","local_convenience_store","E543")},
{ "local dining", new MDLIcon("local dining","local_dining","E556")},
{ "local drink", new MDLIcon("local drink","local_drink","E544")},
{ "local florist", new MDLIcon("local florist","local_florist","E545")},
{ "local gas station", new MDLIcon("local gas station","local_gas_station","E546")},
{ "local grocery store", new MDLIcon("local grocery store","local_grocery_store","E547")},
{ "local hospital", new MDLIcon("local hospital","local_hospital","E548")},
{ "local hotel", new MDLIcon("local hotel","local_hotel","E549")},
{ "local laundry service", new MDLIcon("local laundry service","local_laundry_service","E54A")},
{ "local library", new MDLIcon("local library","local_library","E54B")},
{ "local mall", new MDLIcon("local mall","local_mall","E54C")},
{ "local movies", new MDLIcon("local movies","local_movies","E54D")},
{ "local offer", new MDLIcon("local offer","local_offer","E54E")},
{ "local parking", new MDLIcon("local parking","local_parking","E54F")},
{ "local pharmacy", new MDLIcon("local pharmacy","local_pharmacy","E550")},
{ "local phone", new MDLIcon("local phone","local_phone","E551")},
{ "local pizza", new MDLIcon("local pizza","local_pizza","E552")},
{ "local play", new MDLIcon("local play","local_play","E553")},
{ "local post office", new MDLIcon("local post office","local_post_office","E554")},
{ "local printshop", new MDLIcon("local printshop","local_printshop","E555")},
{ "local see", new MDLIcon("local see","local_see","E557")},
{ "local shipping", new MDLIcon("local shipping","local_shipping","E558")},
{ "local taxi", new MDLIcon("local taxi","local_taxi","E559")},
{ "map", new MDLIcon("map","map","E55B")},
{ "my location", new MDLIcon("my location","my_location","E55C")},
{ "navigation", new MDLIcon("navigation","navigation","E55D")},
{ "near me", new MDLIcon("near me","near_me","E569")},
{ "person pin", new MDLIcon("person pin","person_pin","E55A")},
{ "person pin circle", new MDLIcon("person pin circle","person_pin_circle","E56A")},
{ "pin drop", new MDLIcon("pin drop","pin_drop","E55E")},
{ "place", new MDLIcon("place","place","E55F")},
{ "rate review", new MDLIcon("rate review","rate_review","E560")},
{ "restaurant menu", new MDLIcon("restaurant menu","restaurant_menu","E561")},
{ "satellite", new MDLIcon("satellite","satellite","E562")},
{ "store mall directory", new MDLIcon("store mall directory","store_mall_directory","E563")},
{ "terrain", new MDLIcon("terrain","terrain","E564")},
{ "traffic", new MDLIcon("traffic","traffic","E565")},
{ "zoom out map", new MDLIcon("zoom out map","zoom_out_map","E56B")},
{ "apps", new MDLIcon("apps","apps","E5C3")},
{ "arrow back", new MDLIcon("arrow back","arrow_back","E5C4")},
{ "arrow downward", new MDLIcon("arrow downward","arrow_downward","E5DB")},
{ "arrow drop down", new MDLIcon("arrow drop down","arrow_drop_down","E5C5")},
{ "arrow drop down circle", new MDLIcon("arrow drop down circle","arrow_drop_down_circle","E5C6")},
{ "arrow drop up", new MDLIcon("arrow drop up","arrow_drop_up","E5C7")},
{ "arrow forward", new MDLIcon("arrow forward","arrow_forward","E5C8")},
{ "arrow upward", new MDLIcon("arrow upward","arrow_upward","E5D8")},
{ "cancel", new MDLIcon("cancel","cancel","E5C9")},
{ "check", new MDLIcon("check","check","E5CA")},
{ "chevron left", new MDLIcon("chevron left","chevron_left","E5CB")},
{ "chevron right", new MDLIcon("chevron right","chevron_right","E5CC")},
{ "close", new MDLIcon("close","close","E5CD")},
{ "expand less", new MDLIcon("expand less","expand_less","E5CE")},
{ "expand more", new MDLIcon("expand more","expand_more","E5CF")},
{ "fullscreen", new MDLIcon("fullscreen","fullscreen","E5D0")},
{ "fullscreen exit", new MDLIcon("fullscreen exit","fullscreen_exit","E5D1")},
{ "menu", new MDLIcon("menu","menu","E5D2")},
{ "more horiz", new MDLIcon("more horiz","more_horiz","E5D3")},
{ "more vert", new MDLIcon("more vert","more_vert","E5D4")},
{ "refresh", new MDLIcon("refresh","refresh","E5D5")},
{ "subdirectory arrow left", new MDLIcon("subdirectory arrow left","subdirectory_arrow_left","E5D9")},
{ "subdirectory arrow right", new MDLIcon("subdirectory arrow right","subdirectory_arrow_right","E5DA")},
{ "adb", new MDLIcon("adb","adb","E60E")},
{ "airline seat flat", new MDLIcon("airline seat flat","airline_seat_flat","E630")},
{ "airline seat flat angled", new MDLIcon("airline seat flat angled","airline_seat_flat_angled","E631")},
{ "airline seat individual suite", new MDLIcon("airline seat individual suite","airline_seat_individual_suite","E632")},
{ "airline seat legroom extra", new MDLIcon("airline seat legroom extra","airline_seat_legroom_extra","E633")},
{ "airline seat legroom normal", new MDLIcon("airline seat legroom normal","airline_seat_legroom_normal","E634")},
{ "airline seat legroom reduced", new MDLIcon("airline seat legroom reduced","airline_seat_legroom_reduced","E635")},
{ "airline seat recline extra", new MDLIcon("airline seat recline extra","airline_seat_recline_extra","E636")},
{ "airline seat recline normal", new MDLIcon("airline seat recline normal","airline_seat_recline_normal","E637")},
{ "bluetooth audio", new MDLIcon("bluetooth audio","bluetooth_audio","E60F")},
{ "confirmation number", new MDLIcon("confirmation number","confirmation_number","E638")},
{ "disc full", new MDLIcon("disc full","disc_full","E610")},
{ "do not disturb", new MDLIcon("do not disturb","do_not_disturb","E612")},
{ "do not disturb alt", new MDLIcon("do not disturb alt","do_not_disturb_alt","E611")},
{ "drive eta", new MDLIcon("drive eta","drive_eta","E613")},
{ "enhanced encryption", new MDLIcon("enhanced encryption","enhanced_encryption","E63F")},
{ "event available", new MDLIcon("event available","event_available","E614")},
{ "event busy", new MDLIcon("event busy","event_busy","E615")},
{ "event note", new MDLIcon("event note","event_note","E616")},
{ "folder special", new MDLIcon("folder special","folder_special","E617")},
{ "live tv", new MDLIcon("live tv","live_tv","E639")},
{ "mms", new MDLIcon("mms","mms","E618")},
{ "more", new MDLIcon("more","more","E619")},
{ "network check", new MDLIcon("network check","network_check","E640")},
{ "network locked", new MDLIcon("network locked","network_locked","E61A")},
{ "no encryption", new MDLIcon("no encryption","no_encryption","E641")},
{ "ondemand video", new MDLIcon("ondemand video","ondemand_video","E63A")},
{ "personal video", new MDLIcon("personal video","personal_video","E63B")},
{ "phone bluetooth speaker", new MDLIcon("phone bluetooth speaker","phone_bluetooth_speaker","E61B")},
{ "phone forwarded", new MDLIcon("phone forwarded","phone_forwarded","E61C")},
{ "phone in talk", new MDLIcon("phone in talk","phone_in_talk","E61D")},
{ "phone locked", new MDLIcon("phone locked","phone_locked","E61E")},
{ "phone missed", new MDLIcon("phone missed","phone_missed","E61F")},
{ "phone paused", new MDLIcon("phone paused","phone_paused","E620")},
{ "power", new MDLIcon("power","power","E63C")},
{ "sd card", new MDLIcon("sd card","sd_card","E623")},
{ "sim card alert", new MDLIcon("sim card alert","sim_card_alert","E624")},
{ "sms", new MDLIcon("sms","sms","E625")},
{ "sms failed", new MDLIcon("sms failed","sms_failed","E626")},
{ "sync", new MDLIcon("sync","sync","E627")},
{ "sync disabled", new MDLIcon("sync disabled","sync_disabled","E628")},
{ "sync problem", new MDLIcon("sync problem","sync_problem","E629")},
{ "system update", new MDLIcon("system update","system_update","E62A")},
{ "tap and play", new MDLIcon("tap and play","tap_and_play","E62B")},
{ "time to leave", new MDLIcon("time to leave","time_to_leave","E62C")},
{ "vibration", new MDLIcon("vibration","vibration","E62D")},
{ "voice chat", new MDLIcon("voice chat","voice_chat","E62E")},
{ "vpn lock", new MDLIcon("vpn lock","vpn_lock","E62F")},
{ "wc", new MDLIcon("wc","wc","E63D")},
{ "wifi", new MDLIcon("wifi","wifi","E63E")},
{ "ac unit", new MDLIcon("ac unit","ac_unit","EB3B")},
{ "airport shuttle", new MDLIcon("airport shuttle","airport_shuttle","EB3C")},
{ "all inclusive", new MDLIcon("all inclusive","all_inclusive","EB3D")},
{ "beach access", new MDLIcon("beach access","beach_access","EB3E")},
{ "business center", new MDLIcon("business center","business_center","EB3F")},
{ "casino", new MDLIcon("casino","casino","EB40")},
{ "child care", new MDLIcon("child care","child_care","EB41")},
{ "child friendly", new MDLIcon("child friendly","child_friendly","EB42")},
{ "fitness center", new MDLIcon("fitness center","fitness_center","EB43")},
{ "free breakfast", new MDLIcon("free breakfast","free_breakfast","EB44")},
{ "golf course", new MDLIcon("golf course","golf_course","EB45")},
{ "hot tub", new MDLIcon("hot tub","hot_tub","EB46")},
{ "kitchen", new MDLIcon("kitchen","kitchen","EB47")},
{ "pool", new MDLIcon("pool","pool","EB48")},
{ "room service", new MDLIcon("room service","room_service","EB49")},
{ "rv hookup", new MDLIcon("rv hookup","rv_hookup","E642")},
{ "smoke free", new MDLIcon("smoke free","smoke_free","EB4A")},
{ "smoking rooms", new MDLIcon("smoking rooms","smoking_rooms","EB4B")},
{ "spa", new MDLIcon("spa","spa","EB4C")},
{ "cake", new MDLIcon("cake","cake","E7E9")},
{ "domain", new MDLIcon("domain","domain","E7EE")},
{ "group", new MDLIcon("group","group","E7EF")},
{ "group add", new MDLIcon("group add","group_add","E7F0")},
{ "location city", new MDLIcon("location city","location_city","E7F1")},
{ "mood", new MDLIcon("mood","mood","E7F2")},
{ "mood bad", new MDLIcon("mood bad","mood_bad","E7F3")},
{ "notifications", new MDLIcon("notifications","notifications","E7F4")},
{ "notifications active", new MDLIcon("notifications active","notifications_active","E7F7")},
{ "notifications none", new MDLIcon("notifications none","notifications_none","E7F5")},
{ "notifications off", new MDLIcon("notifications off","notifications_off","E7F6")},
{ "notifications paused", new MDLIcon("notifications paused","notifications_paused","E7F8")},
{ "pages", new MDLIcon("pages","pages","E7F9")},
{ "party mode", new MDLIcon("party mode","party_mode","E7FA")},
{ "people", new MDLIcon("people","people","E7FB")},
{ "people outline", new MDLIcon("people outline","people_outline","E7FC")},
{ "person", new MDLIcon("person","person","E7FD")},
{ "person add", new MDLIcon("person add","person_add","E7FE")},
{ "person outline", new MDLIcon("person outline","person_outline","E7FF")},
{ "plus one", new MDLIcon("plus one","plus_one","E800")},
{ "poll", new MDLIcon("poll","poll","E801")},
{ "public", new MDLIcon("public","public","E80B")},
{ "school", new MDLIcon("school","school","E80C")},
{ "share", new MDLIcon("share","share","E80D")},
{ "whatshot", new MDLIcon("whatshot","whatshot","E80E")},
{ "check box", new MDLIcon("check box","check_box","E834")},
{ "check box outline blank", new MDLIcon("check box outline blank","check_box_outline_blank","E835")},
{ "indeterminate check box", new MDLIcon("indeterminate check box","indeterminate_check_box","E909")},
{ "radio button checked", new MDLIcon("radio button checked","radio_button_checked","E837")},
{ "radio button unchecked", new MDLIcon("radio button unchecked","radio_button_unchecked","E836")},
{ "star", new MDLIcon("star","star","E838")},
{ "star border", new MDLIcon("star border","star_border","E83A")},
{ "star half", new MDLIcon("star half","star_half","E839")},
        };

        public static MDLIcon ThreeD_rotation { get { return _allIcons["3d rotation"]; } }
        public static MDLIcon accessibility { get { return _allIcons["accessibility"]; } }
        public static MDLIcon accessible { get { return _allIcons["accessible"]; } }
        public static MDLIcon account_balance { get { return _allIcons["account balance"]; } }
        public static MDLIcon account_balance_wallet { get { return _allIcons["account balance wallet"]; } }
        public static MDLIcon account_box { get { return _allIcons["account box"]; } }
        public static MDLIcon account_circle { get { return _allIcons["account circle"]; } }
        public static MDLIcon add_shopping_cart { get { return _allIcons["add shopping cart"]; } }
        public static MDLIcon alarm { get { return _allIcons["alarm"]; } }
        public static MDLIcon alarm_add { get { return _allIcons["alarm add"]; } }
        public static MDLIcon alarm_off { get { return _allIcons["alarm off"]; } }
        public static MDLIcon alarm_on { get { return _allIcons["alarm on"]; } }
        public static MDLIcon all_out { get { return _allIcons["all out"]; } }
        public static MDLIcon android { get { return _allIcons["android"]; } }
        public static MDLIcon announcement { get { return _allIcons["announcement"]; } }
        public static MDLIcon aspect_ratio { get { return _allIcons["aspect ratio"]; } }
        public static MDLIcon assessment { get { return _allIcons["assessment"]; } }
        public static MDLIcon assignment { get { return _allIcons["assignment"]; } }
        public static MDLIcon assignment_ind { get { return _allIcons["assignment ind"]; } }
        public static MDLIcon assignment_late { get { return _allIcons["assignment late"]; } }
        public static MDLIcon assignment_return { get { return _allIcons["assignment return"]; } }
        public static MDLIcon assignment_returned { get { return _allIcons["assignment returned"]; } }
        public static MDLIcon assignment_turned_in { get { return _allIcons["assignment turned in"]; } }
        public static MDLIcon autorenew { get { return _allIcons["autorenew"]; } }
        public static MDLIcon backup { get { return _allIcons["backup"]; } }
        public static MDLIcon book { get { return _allIcons["book"]; } }
        public static MDLIcon bookmark { get { return _allIcons["bookmark"]; } }
        public static MDLIcon bookmark_border { get { return _allIcons["bookmark border"]; } }
        public static MDLIcon bug_report { get { return _allIcons["bug report"]; } }
        public static MDLIcon build { get { return _allIcons["build"]; } }
        public static MDLIcon cached { get { return _allIcons["cached"]; } }
        public static MDLIcon camera_enhance { get { return _allIcons["camera enhance"]; } }
        public static MDLIcon card_giftcard { get { return _allIcons["card giftcard"]; } }
        public static MDLIcon card_membership { get { return _allIcons["card membership"]; } }
        public static MDLIcon card_travel { get { return _allIcons["card travel"]; } }
        public static MDLIcon change_history { get { return _allIcons["change history"]; } }
        public static MDLIcon check_circle { get { return _allIcons["check circle"]; } }
        public static MDLIcon chrome_reader_mode { get { return _allIcons["chrome reader mode"]; } }
        public static MDLIcon @class { get { return _allIcons["class"]; } }
        public static MDLIcon code { get { return _allIcons["code"]; } }
        public static MDLIcon compare_arrows { get { return _allIcons["compare arrows"]; } }
        public static MDLIcon copyright { get { return _allIcons["copyright"]; } }
        public static MDLIcon credit_card { get { return _allIcons["credit card"]; } }
        public static MDLIcon dashboard { get { return _allIcons["dashboard"]; } }
        public static MDLIcon date_range { get { return _allIcons["date range"]; } }
        public static MDLIcon delete { get { return _allIcons["delete"]; } }
        public static MDLIcon description { get { return _allIcons["description"]; } }
        public static MDLIcon dns { get { return _allIcons["dns"]; } }
        public static MDLIcon done { get { return _allIcons["done"]; } }
        public static MDLIcon done_all { get { return _allIcons["done all"]; } }
        public static MDLIcon donut_large { get { return _allIcons["donut large"]; } }
        public static MDLIcon donut_small { get { return _allIcons["donut small"]; } }
        public static MDLIcon eject { get { return _allIcons["eject"]; } }
        public static MDLIcon @event { get { return _allIcons["event"]; } }
        public static MDLIcon event_seat { get { return _allIcons["event seat"]; } }
        public static MDLIcon exit_to_app { get { return _allIcons["exit to app"]; } }
        public static MDLIcon explore { get { return _allIcons["explore"]; } }
        public static MDLIcon extension { get { return _allIcons["extension"]; } }
        public static MDLIcon face { get { return _allIcons["face"]; } }
        public static MDLIcon favorite { get { return _allIcons["favorite"]; } }
        public static MDLIcon favorite_border { get { return _allIcons["favorite border"]; } }
        public static MDLIcon feedback { get { return _allIcons["feedback"]; } }
        public static MDLIcon find_in_page { get { return _allIcons["find in page"]; } }
        public static MDLIcon find_replace { get { return _allIcons["find replace"]; } }
        public static MDLIcon fingerprint { get { return _allIcons["fingerprint"]; } }
        public static MDLIcon flight_land { get { return _allIcons["flight land"]; } }
        public static MDLIcon flight_takeoff { get { return _allIcons["flight takeoff"]; } }
        public static MDLIcon flip_to_back { get { return _allIcons["flip to back"]; } }
        public static MDLIcon flip_to_front { get { return _allIcons["flip to front"]; } }
        public static MDLIcon gavel { get { return _allIcons["gavel"]; } }
        public static MDLIcon get_app { get { return _allIcons["get app"]; } }
        public static MDLIcon gif { get { return _allIcons["gif"]; } }
        public static MDLIcon grade { get { return _allIcons["grade"]; } }
        public static MDLIcon group_work { get { return _allIcons["group work"]; } }
        public static MDLIcon help { get { return _allIcons["help"]; } }
        public static MDLIcon help_outline { get { return _allIcons["help outline"]; } }
        public static MDLIcon highlight_off { get { return _allIcons["highlight off"]; } }
        public static MDLIcon history { get { return _allIcons["history"]; } }
        public static MDLIcon home { get { return _allIcons["home"]; } }
        public static MDLIcon hourglass_empty { get { return _allIcons["hourglass empty"]; } }
        public static MDLIcon hourglass_full { get { return _allIcons["hourglass full"]; } }
        public static MDLIcon http { get { return _allIcons["http"]; } }
        public static MDLIcon https { get { return _allIcons["https"]; } }
        public static MDLIcon important_devices { get { return _allIcons["important devices"]; } }
        public static MDLIcon info { get { return _allIcons["info"]; } }
        public static MDLIcon info_outline { get { return _allIcons["info outline"]; } }
        public static MDLIcon input { get { return _allIcons["input"]; } }
        public static MDLIcon invert_colors { get { return _allIcons["invert colors"]; } }
        public static MDLIcon label { get { return _allIcons["label"]; } }
        public static MDLIcon label_outline { get { return _allIcons["label outline"]; } }
        public static MDLIcon language { get { return _allIcons["language"]; } }
        public static MDLIcon launch { get { return _allIcons["launch"]; } }
        public static MDLIcon lightbulb_outline { get { return _allIcons["lightbulb outline"]; } }
        public static MDLIcon line_style { get { return _allIcons["line style"]; } }
        public static MDLIcon line_weight { get { return _allIcons["line weight"]; } }
        public static MDLIcon list { get { return _allIcons["list"]; } }
        public static MDLIcon @lock { get { return _allIcons["lock"]; } }
        public static MDLIcon lock_open { get { return _allIcons["lock open"]; } }
        public static MDLIcon lock_outline { get { return _allIcons["lock outline"]; } }
        public static MDLIcon loyalty { get { return _allIcons["loyalty"]; } }
        public static MDLIcon markunread_mailbox { get { return _allIcons["markunread mailbox"]; } }
        public static MDLIcon motorcycle { get { return _allIcons["motorcycle"]; } }
        public static MDLIcon note_add { get { return _allIcons["note add"]; } }
        public static MDLIcon offline_pin { get { return _allIcons["offline pin"]; } }
        public static MDLIcon opacity { get { return _allIcons["opacity"]; } }
        public static MDLIcon open_in_browser { get { return _allIcons["open in browser"]; } }
        public static MDLIcon open_in_new { get { return _allIcons["open in new"]; } }
        public static MDLIcon open_with { get { return _allIcons["open with"]; } }
        public static MDLIcon pageview { get { return _allIcons["pageview"]; } }
        public static MDLIcon pan_tool { get { return _allIcons["pan tool"]; } }
        public static MDLIcon payment { get { return _allIcons["payment"]; } }
        public static MDLIcon perm_camera_mic { get { return _allIcons["perm camera mic"]; } }
        public static MDLIcon perm_contact_calendar { get { return _allIcons["perm contact calendar"]; } }
        public static MDLIcon perm_data_setting { get { return _allIcons["perm data setting"]; } }
        public static MDLIcon perm_device_information { get { return _allIcons["perm device information"]; } }
        public static MDLIcon perm_identity { get { return _allIcons["perm identity"]; } }
        public static MDLIcon perm_media { get { return _allIcons["perm media"]; } }
        public static MDLIcon perm_phone_msg { get { return _allIcons["perm phone msg"]; } }
        public static MDLIcon perm_scan_wifi { get { return _allIcons["perm scan wifi"]; } }
        public static MDLIcon pets { get { return _allIcons["pets"]; } }
        public static MDLIcon picture_in_picture { get { return _allIcons["picture in picture"]; } }
        public static MDLIcon picture_in_picture_alt { get { return _allIcons["picture in picture alt"]; } }
        public static MDLIcon play_for_work { get { return _allIcons["play for work"]; } }
        public static MDLIcon polymer { get { return _allIcons["polymer"]; } }
        public static MDLIcon power_settings_new { get { return _allIcons["power settings new"]; } }
        public static MDLIcon pregnant_woman { get { return _allIcons["pregnant woman"]; } }
        public static MDLIcon print { get { return _allIcons["print"]; } }
        public static MDLIcon query_builder { get { return _allIcons["query builder"]; } }
        public static MDLIcon question_answer { get { return _allIcons["question answer"]; } }
        public static MDLIcon receipt { get { return _allIcons["receipt"]; } }
        public static MDLIcon record_voice_over { get { return _allIcons["record voice over"]; } }
        public static MDLIcon redeem { get { return _allIcons["redeem"]; } }
        public static MDLIcon reorder { get { return _allIcons["reorder"]; } }
        public static MDLIcon report_problem { get { return _allIcons["report problem"]; } }
        public static MDLIcon restore { get { return _allIcons["restore"]; } }
        public static MDLIcon room { get { return _allIcons["room"]; } }
        public static MDLIcon rounded_corner { get { return _allIcons["rounded corner"]; } }
        public static MDLIcon rowing { get { return _allIcons["rowing"]; } }
        public static MDLIcon schedule { get { return _allIcons["schedule"]; } }
        public static MDLIcon search { get { return _allIcons["search"]; } }
        public static MDLIcon settings { get { return _allIcons["settings"]; } }
        public static MDLIcon settings_applications { get { return _allIcons["settings applications"]; } }
        public static MDLIcon settings_backup_restore { get { return _allIcons["settings backup restore"]; } }
        public static MDLIcon settings_bluetooth { get { return _allIcons["settings bluetooth"]; } }
        public static MDLIcon settings_brightness { get { return _allIcons["settings brightness"]; } }
        public static MDLIcon settings_cell { get { return _allIcons["settings cell"]; } }
        public static MDLIcon settings_ethernet { get { return _allIcons["settings ethernet"]; } }
        public static MDLIcon settings_input_antenna { get { return _allIcons["settings input antenna"]; } }
        public static MDLIcon settings_input_component { get { return _allIcons["settings input component"]; } }
        public static MDLIcon settings_input_composite { get { return _allIcons["settings input composite"]; } }
        public static MDLIcon settings_input_hdmi { get { return _allIcons["settings input hdmi"]; } }
        public static MDLIcon settings_input_svideo { get { return _allIcons["settings input svideo"]; } }
        public static MDLIcon settings_overscan { get { return _allIcons["settings overscan"]; } }
        public static MDLIcon settings_phone { get { return _allIcons["settings phone"]; } }
        public static MDLIcon settings_power { get { return _allIcons["settings power"]; } }
        public static MDLIcon settings_remote { get { return _allIcons["settings remote"]; } }
        public static MDLIcon settings_voice { get { return _allIcons["settings voice"]; } }
        public static MDLIcon shop { get { return _allIcons["shop"]; } }
        public static MDLIcon shop_two { get { return _allIcons["shop two"]; } }
        public static MDLIcon shopping_basket { get { return _allIcons["shopping basket"]; } }
        public static MDLIcon shopping_cart { get { return _allIcons["shopping cart"]; } }
        public static MDLIcon speaker_notes { get { return _allIcons["speaker notes"]; } }
        public static MDLIcon spellcheck { get { return _allIcons["spellcheck"]; } }
        public static MDLIcon star_rate { get { return _allIcons["star rate"]; } }
        public static MDLIcon stars { get { return _allIcons["stars"]; } }
        public static MDLIcon store { get { return _allIcons["store"]; } }
        public static MDLIcon subject { get { return _allIcons["subject"]; } }
        public static MDLIcon supervisor_account { get { return _allIcons["supervisor account"]; } }
        public static MDLIcon swap_horiz { get { return _allIcons["swap horiz"]; } }
        public static MDLIcon swap_vert { get { return _allIcons["swap vert"]; } }
        public static MDLIcon swap_vertical_circle { get { return _allIcons["swap vertical circle"]; } }
        public static MDLIcon system_update_alt { get { return _allIcons["system update alt"]; } }
        public static MDLIcon tab { get { return _allIcons["tab"]; } }
        public static MDLIcon tab_unselected { get { return _allIcons["tab unselected"]; } }
        public static MDLIcon theaters { get { return _allIcons["theaters"]; } }
        public static MDLIcon thumb_down { get { return _allIcons["thumb down"]; } }
        public static MDLIcon thumb_up { get { return _allIcons["thumb up"]; } }
        public static MDLIcon thumbs_up_down { get { return _allIcons["thumbs up down"]; } }
        public static MDLIcon timeline { get { return _allIcons["timeline"]; } }
        public static MDLIcon toc { get { return _allIcons["toc"]; } }
        public static MDLIcon today { get { return _allIcons["today"]; } }
        public static MDLIcon toll { get { return _allIcons["toll"]; } }
        public static MDLIcon touch_app { get { return _allIcons["touch app"]; } }
        public static MDLIcon track_changes { get { return _allIcons["track changes"]; } }
        public static MDLIcon translate { get { return _allIcons["translate"]; } }
        public static MDLIcon trending_down { get { return _allIcons["trending down"]; } }
        public static MDLIcon trending_flat { get { return _allIcons["trending flat"]; } }
        public static MDLIcon trending_up { get { return _allIcons["trending up"]; } }
        public static MDLIcon turned_in { get { return _allIcons["turned in"]; } }
        public static MDLIcon turned_in_not { get { return _allIcons["turned in not"]; } }
        public static MDLIcon update { get { return _allIcons["update"]; } }
        public static MDLIcon verified_user { get { return _allIcons["verified user"]; } }
        public static MDLIcon view_agenda { get { return _allIcons["view agenda"]; } }
        public static MDLIcon view_array { get { return _allIcons["view array"]; } }
        public static MDLIcon view_carousel { get { return _allIcons["view carousel"]; } }
        public static MDLIcon view_column { get { return _allIcons["view column"]; } }
        public static MDLIcon view_day { get { return _allIcons["view day"]; } }
        public static MDLIcon view_headline { get { return _allIcons["view headline"]; } }
        public static MDLIcon view_list { get { return _allIcons["view list"]; } }
        public static MDLIcon view_module { get { return _allIcons["view module"]; } }
        public static MDLIcon view_quilt { get { return _allIcons["view quilt"]; } }
        public static MDLIcon view_stream { get { return _allIcons["view stream"]; } }
        public static MDLIcon view_week { get { return _allIcons["view week"]; } }
        public static MDLIcon visibility { get { return _allIcons["visibility"]; } }
        public static MDLIcon visibility_off { get { return _allIcons["visibility off"]; } }
        public static MDLIcon watch_later { get { return _allIcons["watch later"]; } }
        public static MDLIcon work { get { return _allIcons["work"]; } }
        public static MDLIcon youtube_searched_for { get { return _allIcons["youtube searched for"]; } }
        public static MDLIcon zoom_in { get { return _allIcons["zoom in"]; } }
        public static MDLIcon zoom_out { get { return _allIcons["zoom out"]; } }
        public static MDLIcon add_alert { get { return _allIcons["add alert"]; } }
        public static MDLIcon error { get { return _allIcons["error"]; } }
        public static MDLIcon error_outline { get { return _allIcons["error outline"]; } }
        public static MDLIcon warning { get { return _allIcons["warning"]; } }
        public static MDLIcon add_to_queue { get { return _allIcons["add to queue"]; } }
        public static MDLIcon airplay { get { return _allIcons["airplay"]; } }
        public static MDLIcon album { get { return _allIcons["album"]; } }
        public static MDLIcon art_track { get { return _allIcons["art track"]; } }
        public static MDLIcon av_timer { get { return _allIcons["av timer"]; } }
        public static MDLIcon closed_caption { get { return _allIcons["closed caption"]; } }
        public static MDLIcon equalizer { get { return _allIcons["equalizer"]; } }
        public static MDLIcon @explicit { get { return _allIcons["explicit"]; } }
        public static MDLIcon fast_forward { get { return _allIcons["fast forward"]; } }
        public static MDLIcon fast_rewind { get { return _allIcons["fast rewind"]; } }
        public static MDLIcon fiber_dvr { get { return _allIcons["fiber dvr"]; } }
        public static MDLIcon fiber_manual_record { get { return _allIcons["fiber manual record"]; } }
        public static MDLIcon fiber_new { get { return _allIcons["fiber new"]; } }
        public static MDLIcon fiber_pin { get { return _allIcons["fiber pin"]; } }
        public static MDLIcon fiber_smart_record { get { return _allIcons["fiber smart record"]; } }
        public static MDLIcon forward_10 { get { return _allIcons["forward 10"]; } }
        public static MDLIcon forward_30 { get { return _allIcons["forward 30"]; } }
        public static MDLIcon forward_5 { get { return _allIcons["forward 5"]; } }
        public static MDLIcon games { get { return _allIcons["games"]; } }
        public static MDLIcon hd { get { return _allIcons["hd"]; } }
        public static MDLIcon hearing { get { return _allIcons["hearing"]; } }
        public static MDLIcon high_quality { get { return _allIcons["high quality"]; } }
        public static MDLIcon library_add { get { return _allIcons["library add"]; } }
        public static MDLIcon library_books { get { return _allIcons["library books"]; } }
        public static MDLIcon library_music { get { return _allIcons["library music"]; } }
        public static MDLIcon loop { get { return _allIcons["loop"]; } }
        public static MDLIcon mic { get { return _allIcons["mic"]; } }
        public static MDLIcon mic_none { get { return _allIcons["mic none"]; } }
        public static MDLIcon mic_off { get { return _allIcons["mic off"]; } }
        public static MDLIcon movie { get { return _allIcons["movie"]; } }
        public static MDLIcon music_video { get { return _allIcons["music video"]; } }
        public static MDLIcon new_releases { get { return _allIcons["new releases"]; } }
        public static MDLIcon not_interested { get { return _allIcons["not interested"]; } }
        public static MDLIcon pause { get { return _allIcons["pause"]; } }
        public static MDLIcon pause_circle_filled { get { return _allIcons["pause circle filled"]; } }
        public static MDLIcon pause_circle_outline { get { return _allIcons["pause circle outline"]; } }
        public static MDLIcon play_arrow { get { return _allIcons["play arrow"]; } }
        public static MDLIcon play_circle_filled { get { return _allIcons["play circle filled"]; } }
        public static MDLIcon play_circle_outline { get { return _allIcons["play circle outline"]; } }
        public static MDLIcon playlist_add { get { return _allIcons["playlist add"]; } }
        public static MDLIcon playlist_add_check { get { return _allIcons["playlist add check"]; } }
        public static MDLIcon playlist_play { get { return _allIcons["playlist play"]; } }
        public static MDLIcon queue { get { return _allIcons["queue"]; } }
        public static MDLIcon queue_music { get { return _allIcons["queue music"]; } }
        public static MDLIcon queue_play_next { get { return _allIcons["queue play next"]; } }
        public static MDLIcon radio { get { return _allIcons["radio"]; } }
        public static MDLIcon recent_actors { get { return _allIcons["recent actors"]; } }
        public static MDLIcon remove_from_queue { get { return _allIcons["remove from queue"]; } }
        public static MDLIcon repeat { get { return _allIcons["repeat"]; } }
        public static MDLIcon repeat_one { get { return _allIcons["repeat one"]; } }
        public static MDLIcon replay { get { return _allIcons["replay"]; } }
        public static MDLIcon replay_10 { get { return _allIcons["replay 10"]; } }
        public static MDLIcon replay_30 { get { return _allIcons["replay 30"]; } }
        public static MDLIcon replay_5 { get { return _allIcons["replay 5"]; } }
        public static MDLIcon shuffle { get { return _allIcons["shuffle"]; } }
        public static MDLIcon skip_next { get { return _allIcons["skip next"]; } }
        public static MDLIcon skip_previous { get { return _allIcons["skip previous"]; } }
        public static MDLIcon slow_motion_video { get { return _allIcons["slow motion video"]; } }
        public static MDLIcon snooze { get { return _allIcons["snooze"]; } }
        public static MDLIcon sort_by_alpha { get { return _allIcons["sort by alpha"]; } }
        public static MDLIcon stop { get { return _allIcons["stop"]; } }
        public static MDLIcon subscriptions { get { return _allIcons["subscriptions"]; } }
        public static MDLIcon subtitles { get { return _allIcons["subtitles"]; } }
        public static MDLIcon surround_sound { get { return _allIcons["surround sound"]; } }
        public static MDLIcon video_library { get { return _allIcons["video library"]; } }
        public static MDLIcon videocam { get { return _allIcons["videocam"]; } }
        public static MDLIcon videocam_off { get { return _allIcons["videocam off"]; } }
        public static MDLIcon volume_down { get { return _allIcons["volume down"]; } }
        public static MDLIcon volume_mute { get { return _allIcons["volume mute"]; } }
        public static MDLIcon volume_off { get { return _allIcons["volume off"]; } }
        public static MDLIcon volume_up { get { return _allIcons["volume up"]; } }
        public static MDLIcon web { get { return _allIcons["web"]; } }
        public static MDLIcon web_asset { get { return _allIcons["web asset"]; } }
        public static MDLIcon business { get { return _allIcons["business"]; } }
        public static MDLIcon call { get { return _allIcons["call"]; } }
        public static MDLIcon call_end { get { return _allIcons["call end"]; } }
        public static MDLIcon call_made { get { return _allIcons["call made"]; } }
        public static MDLIcon call_merge { get { return _allIcons["call merge"]; } }
        public static MDLIcon call_missed { get { return _allIcons["call missed"]; } }
        public static MDLIcon call_missed_outgoing { get { return _allIcons["call missed outgoing"]; } }
        public static MDLIcon call_received { get { return _allIcons["call received"]; } }
        public static MDLIcon call_split { get { return _allIcons["call split"]; } }
        public static MDLIcon chat { get { return _allIcons["chat"]; } }
        public static MDLIcon chat_bubble { get { return _allIcons["chat bubble"]; } }
        public static MDLIcon chat_bubble_outline { get { return _allIcons["chat bubble outline"]; } }
        public static MDLIcon clear_all { get { return _allIcons["clear all"]; } }
        public static MDLIcon comment { get { return _allIcons["comment"]; } }
        public static MDLIcon contact_mail { get { return _allIcons["contact mail"]; } }
        public static MDLIcon contact_phone { get { return _allIcons["contact phone"]; } }
        public static MDLIcon contacts { get { return _allIcons["contacts"]; } }
        public static MDLIcon dialer_sip { get { return _allIcons["dialer sip"]; } }
        public static MDLIcon dialpad { get { return _allIcons["dialpad"]; } }
        public static MDLIcon email { get { return _allIcons["email"]; } }
        public static MDLIcon forum { get { return _allIcons["forum"]; } }
        public static MDLIcon import_contacts { get { return _allIcons["import contacts"]; } }
        public static MDLIcon import_export { get { return _allIcons["import export"]; } }
        public static MDLIcon invert_colors_off { get { return _allIcons["invert colors off"]; } }
        public static MDLIcon live_help { get { return _allIcons["live help"]; } }
        public static MDLIcon location_off { get { return _allIcons["location off"]; } }
        public static MDLIcon location_on { get { return _allIcons["location on"]; } }
        public static MDLIcon mail_outline { get { return _allIcons["mail outline"]; } }
        public static MDLIcon message { get { return _allIcons["message"]; } }
        public static MDLIcon no_sim { get { return _allIcons["no sim"]; } }
        public static MDLIcon phone { get { return _allIcons["phone"]; } }
        public static MDLIcon phonelink_erase { get { return _allIcons["phonelink erase"]; } }
        public static MDLIcon phonelink_lock { get { return _allIcons["phonelink lock"]; } }
        public static MDLIcon phonelink_ring { get { return _allIcons["phonelink ring"]; } }
        public static MDLIcon phonelink_setup { get { return _allIcons["phonelink setup"]; } }
        public static MDLIcon portable_wifi_off { get { return _allIcons["portable wifi off"]; } }
        public static MDLIcon present_to_all { get { return _allIcons["present to all"]; } }
        public static MDLIcon ring_volume { get { return _allIcons["ring volume"]; } }
        public static MDLIcon screen_share { get { return _allIcons["screen share"]; } }
        public static MDLIcon speaker_phone { get { return _allIcons["speaker phone"]; } }
        public static MDLIcon stay_current_landscape { get { return _allIcons["stay current landscape"]; } }
        public static MDLIcon stay_current_portrait { get { return _allIcons["stay current portrait"]; } }
        public static MDLIcon stay_primary_landscape { get { return _allIcons["stay primary landscape"]; } }
        public static MDLIcon stay_primary_portrait { get { return _allIcons["stay primary portrait"]; } }
        public static MDLIcon stop_screen_share { get { return _allIcons["stop screen share"]; } }
        public static MDLIcon swap_calls { get { return _allIcons["swap calls"]; } }
        public static MDLIcon textsms { get { return _allIcons["textsms"]; } }
        public static MDLIcon voicemail { get { return _allIcons["voicemail"]; } }
        public static MDLIcon vpn_key { get { return _allIcons["vpn key"]; } }
        public static MDLIcon add { get { return _allIcons["add"]; } }
        public static MDLIcon add_box { get { return _allIcons["add box"]; } }
        public static MDLIcon add_circle { get { return _allIcons["add circle"]; } }
        public static MDLIcon add_circle_outline { get { return _allIcons["add circle outline"]; } }
        public static MDLIcon archive { get { return _allIcons["archive"]; } }
        public static MDLIcon backspace { get { return _allIcons["backspace"]; } }
        public static MDLIcon block { get { return _allIcons["block"]; } }
        public static MDLIcon clear { get { return _allIcons["clear"]; } }
        public static MDLIcon content_copy { get { return _allIcons["content copy"]; } }
        public static MDLIcon content_cut { get { return _allIcons["content cut"]; } }
        public static MDLIcon content_paste { get { return _allIcons["content paste"]; } }
        public static MDLIcon create { get { return _allIcons["create"]; } }
        public static MDLIcon drafts { get { return _allIcons["drafts"]; } }
        public static MDLIcon filter_list { get { return _allIcons["filter list"]; } }
        public static MDLIcon flag { get { return _allIcons["flag"]; } }
        public static MDLIcon font_download { get { return _allIcons["font download"]; } }
        public static MDLIcon forward { get { return _allIcons["forward"]; } }
        public static MDLIcon gesture { get { return _allIcons["gesture"]; } }
        public static MDLIcon inbox { get { return _allIcons["inbox"]; } }
        public static MDLIcon link { get { return _allIcons["link"]; } }
        public static MDLIcon mail { get { return _allIcons["mail"]; } }
        public static MDLIcon markunread { get { return _allIcons["markunread"]; } }
        public static MDLIcon move_to_inbox { get { return _allIcons["move to inbox"]; } }
        public static MDLIcon next_week { get { return _allIcons["next week"]; } }
        public static MDLIcon redo { get { return _allIcons["redo"]; } }
        public static MDLIcon remove { get { return _allIcons["remove"]; } }
        public static MDLIcon remove_circle { get { return _allIcons["remove circle"]; } }
        public static MDLIcon remove_circle_outline { get { return _allIcons["remove circle outline"]; } }
        public static MDLIcon reply { get { return _allIcons["reply"]; } }
        public static MDLIcon reply_all { get { return _allIcons["reply all"]; } }
        public static MDLIcon report { get { return _allIcons["report"]; } }
        public static MDLIcon save { get { return _allIcons["save"]; } }
        public static MDLIcon select_all { get { return _allIcons["select all"]; } }
        public static MDLIcon send { get { return _allIcons["send"]; } }
        public static MDLIcon sort { get { return _allIcons["sort"]; } }
        public static MDLIcon text_format { get { return _allIcons["text format"]; } }
        public static MDLIcon unarchive { get { return _allIcons["unarchive"]; } }
        public static MDLIcon undo { get { return _allIcons["undo"]; } }
        public static MDLIcon weekend { get { return _allIcons["weekend"]; } }
        public static MDLIcon access_alarm { get { return _allIcons["access alarm"]; } }
        public static MDLIcon access_alarms { get { return _allIcons["access alarms"]; } }
        public static MDLIcon access_time { get { return _allIcons["access time"]; } }
        public static MDLIcon add_alarm { get { return _allIcons["add alarm"]; } }
        public static MDLIcon airplanemode_active { get { return _allIcons["airplanemode active"]; } }
        public static MDLIcon airplanemode_inactive { get { return _allIcons["airplanemode inactive"]; } }
        public static MDLIcon battery_alert { get { return _allIcons["battery alert"]; } }
        public static MDLIcon battery_charging_full { get { return _allIcons["battery charging full"]; } }
        public static MDLIcon battery_full { get { return _allIcons["battery full"]; } }
        public static MDLIcon battery_std { get { return _allIcons["battery std"]; } }
        public static MDLIcon battery_unknown { get { return _allIcons["battery unknown"]; } }
        public static MDLIcon bluetooth { get { return _allIcons["bluetooth"]; } }
        public static MDLIcon bluetooth_connected { get { return _allIcons["bluetooth connected"]; } }
        public static MDLIcon bluetooth_disabled { get { return _allIcons["bluetooth disabled"]; } }
        public static MDLIcon bluetooth_searching { get { return _allIcons["bluetooth searching"]; } }
        public static MDLIcon brightness_auto { get { return _allIcons["brightness auto"]; } }
        public static MDLIcon brightness_high { get { return _allIcons["brightness high"]; } }
        public static MDLIcon brightness_low { get { return _allIcons["brightness low"]; } }
        public static MDLIcon brightness_medium { get { return _allIcons["brightness medium"]; } }
        public static MDLIcon data_usage { get { return _allIcons["data usage"]; } }
        public static MDLIcon developer_mode { get { return _allIcons["developer mode"]; } }
        public static MDLIcon devices { get { return _allIcons["devices"]; } }
        public static MDLIcon dvr { get { return _allIcons["dvr"]; } }
        public static MDLIcon gps_fixed { get { return _allIcons["gps fixed"]; } }
        public static MDLIcon gps_not_fixed { get { return _allIcons["gps not fixed"]; } }
        public static MDLIcon gps_off { get { return _allIcons["gps off"]; } }
        public static MDLIcon graphic_eq { get { return _allIcons["graphic eq"]; } }
        public static MDLIcon location_disabled { get { return _allIcons["location disabled"]; } }
        public static MDLIcon location_searching { get { return _allIcons["location searching"]; } }
        public static MDLIcon network_cell { get { return _allIcons["network cell"]; } }
        public static MDLIcon network_wifi { get { return _allIcons["network wifi"]; } }
        public static MDLIcon nfc { get { return _allIcons["nfc"]; } }
        public static MDLIcon screen_lock_landscape { get { return _allIcons["screen lock landscape"]; } }
        public static MDLIcon screen_lock_portrait { get { return _allIcons["screen lock portrait"]; } }
        public static MDLIcon screen_lock_rotation { get { return _allIcons["screen lock rotation"]; } }
        public static MDLIcon screen_rotation { get { return _allIcons["screen rotation"]; } }
        public static MDLIcon sd_storage { get { return _allIcons["sd storage"]; } }
        public static MDLIcon settings_system_daydream { get { return _allIcons["settings system daydream"]; } }
        public static MDLIcon signal_cellular_4_bar { get { return _allIcons["signal cellular 4 bar"]; } }
        public static MDLIcon signal_cellular_connected_no_internet_4_bar { get { return _allIcons["signal cellular connected no internet 4 bar"]; } }
        public static MDLIcon signal_cellular_no_sim { get { return _allIcons["signal cellular no sim"]; } }
        public static MDLIcon signal_cellular_null { get { return _allIcons["signal cellular null"]; } }
        public static MDLIcon signal_cellular_off { get { return _allIcons["signal cellular off"]; } }
        public static MDLIcon signal_wifi_4_bar { get { return _allIcons["signal wifi 4 bar"]; } }
        public static MDLIcon signal_wifi_4_bar_lock { get { return _allIcons["signal wifi 4 bar lock"]; } }
        public static MDLIcon signal_wifi_off { get { return _allIcons["signal wifi off"]; } }
        public static MDLIcon storage { get { return _allIcons["storage"]; } }
        public static MDLIcon usb { get { return _allIcons["usb"]; } }
        public static MDLIcon wallpaper { get { return _allIcons["wallpaper"]; } }
        public static MDLIcon widgets { get { return _allIcons["widgets"]; } }
        public static MDLIcon wifi_lock { get { return _allIcons["wifi lock"]; } }
        public static MDLIcon wifi_tethering { get { return _allIcons["wifi tethering"]; } }
        public static MDLIcon attach_file { get { return _allIcons["attach file"]; } }
        public static MDLIcon attach_money { get { return _allIcons["attach money"]; } }
        public static MDLIcon border_all { get { return _allIcons["border all"]; } }
        public static MDLIcon border_bottom { get { return _allIcons["border bottom"]; } }
        public static MDLIcon border_clear { get { return _allIcons["border clear"]; } }
        public static MDLIcon border_color { get { return _allIcons["border color"]; } }
        public static MDLIcon border_horizontal { get { return _allIcons["border horizontal"]; } }
        public static MDLIcon border_inner { get { return _allIcons["border inner"]; } }
        public static MDLIcon border_left { get { return _allIcons["border left"]; } }
        public static MDLIcon border_outer { get { return _allIcons["border outer"]; } }
        public static MDLIcon border_right { get { return _allIcons["border right"]; } }
        public static MDLIcon border_style { get { return _allIcons["border style"]; } }
        public static MDLIcon border_top { get { return _allIcons["border top"]; } }
        public static MDLIcon border_vertical { get { return _allIcons["border vertical"]; } }
        public static MDLIcon drag_handle { get { return _allIcons["drag handle"]; } }
        public static MDLIcon format_align_center { get { return _allIcons["format align center"]; } }
        public static MDLIcon format_align_justify { get { return _allIcons["format align justify"]; } }
        public static MDLIcon format_align_left { get { return _allIcons["format align left"]; } }
        public static MDLIcon format_align_right { get { return _allIcons["format align right"]; } }
        public static MDLIcon format_bold { get { return _allIcons["format bold"]; } }
        public static MDLIcon format_clear { get { return _allIcons["format clear"]; } }
        public static MDLIcon format_color_fill { get { return _allIcons["format color fill"]; } }
        public static MDLIcon format_color_reset { get { return _allIcons["format color reset"]; } }
        public static MDLIcon format_color_text { get { return _allIcons["format color text"]; } }
        public static MDLIcon format_indent_decrease { get { return _allIcons["format indent decrease"]; } }
        public static MDLIcon format_indent_increase { get { return _allIcons["format indent increase"]; } }
        public static MDLIcon format_italic { get { return _allIcons["format italic"]; } }
        public static MDLIcon format_line_spacing { get { return _allIcons["format line spacing"]; } }
        public static MDLIcon format_list_bulleted { get { return _allIcons["format list bulleted"]; } }
        public static MDLIcon format_list_numbered { get { return _allIcons["format list numbered"]; } }
        public static MDLIcon format_paint { get { return _allIcons["format paint"]; } }
        public static MDLIcon format_quote { get { return _allIcons["format quote"]; } }
        public static MDLIcon format_shapes { get { return _allIcons["format shapes"]; } }
        public static MDLIcon format_size { get { return _allIcons["format size"]; } }
        public static MDLIcon format_strikethrough { get { return _allIcons["format strikethrough"]; } }
        public static MDLIcon format_textdirection_l_to_r { get { return _allIcons["format textdirection l to r"]; } }
        public static MDLIcon format_textdirection_r_to_l { get { return _allIcons["format textdirection r to l"]; } }
        public static MDLIcon format_underlined { get { return _allIcons["format underlined"]; } }
        public static MDLIcon functions { get { return _allIcons["functions"]; } }
        public static MDLIcon highlight { get { return _allIcons["highlight"]; } }
        public static MDLIcon insert_chart { get { return _allIcons["insert chart"]; } }
        public static MDLIcon insert_comment { get { return _allIcons["insert comment"]; } }
        public static MDLIcon insert_drive_file { get { return _allIcons["insert drive file"]; } }
        public static MDLIcon insert_emoticon { get { return _allIcons["insert emoticon"]; } }
        public static MDLIcon insert_invitation { get { return _allIcons["insert invitation"]; } }
        public static MDLIcon insert_link { get { return _allIcons["insert link"]; } }
        public static MDLIcon insert_photo { get { return _allIcons["insert photo"]; } }
        public static MDLIcon linear_scale { get { return _allIcons["linear scale"]; } }
        public static MDLIcon merge_type { get { return _allIcons["merge type"]; } }
        public static MDLIcon mode_comment { get { return _allIcons["mode comment"]; } }
        public static MDLIcon mode_edit { get { return _allIcons["mode edit"]; } }
        public static MDLIcon money_off { get { return _allIcons["money off"]; } }
        public static MDLIcon publish { get { return _allIcons["publish"]; } }
        public static MDLIcon short_text { get { return _allIcons["short text"]; } }
        public static MDLIcon space_bar { get { return _allIcons["space bar"]; } }
        public static MDLIcon strikethrough_s { get { return _allIcons["strikethrough s"]; } }
        public static MDLIcon text_fields { get { return _allIcons["text fields"]; } }
        public static MDLIcon vertical_align_bottom { get { return _allIcons["vertical align bottom"]; } }
        public static MDLIcon vertical_align_center { get { return _allIcons["vertical align center"]; } }
        public static MDLIcon vertical_align_top { get { return _allIcons["vertical align top"]; } }
        public static MDLIcon wrap_text { get { return _allIcons["wrap text"]; } }
        public static MDLIcon attachment { get { return _allIcons["attachment"]; } }
        public static MDLIcon cloud { get { return _allIcons["cloud"]; } }
        public static MDLIcon cloud_circle { get { return _allIcons["cloud circle"]; } }
        public static MDLIcon cloud_done { get { return _allIcons["cloud done"]; } }
        public static MDLIcon cloud_download { get { return _allIcons["cloud download"]; } }
        public static MDLIcon cloud_off { get { return _allIcons["cloud off"]; } }
        public static MDLIcon cloud_queue { get { return _allIcons["cloud queue"]; } }
        public static MDLIcon cloud_upload { get { return _allIcons["cloud upload"]; } }
        public static MDLIcon create_new_folder { get { return _allIcons["create new folder"]; } }
        public static MDLIcon file_download { get { return _allIcons["file download"]; } }
        public static MDLIcon file_upload { get { return _allIcons["file upload"]; } }
        public static MDLIcon folder { get { return _allIcons["folder"]; } }
        public static MDLIcon folder_open { get { return _allIcons["folder open"]; } }
        public static MDLIcon folder_shared { get { return _allIcons["folder shared"]; } }
        public static MDLIcon cast { get { return _allIcons["cast"]; } }
        public static MDLIcon cast_connected { get { return _allIcons["cast connected"]; } }
        public static MDLIcon computer { get { return _allIcons["computer"]; } }
        public static MDLIcon desktop_mac { get { return _allIcons["desktop mac"]; } }
        public static MDLIcon desktop_windows { get { return _allIcons["desktop windows"]; } }
        public static MDLIcon developer_board { get { return _allIcons["developer board"]; } }
        public static MDLIcon device_hub { get { return _allIcons["device hub"]; } }
        public static MDLIcon devices_other { get { return _allIcons["devices other"]; } }
        public static MDLIcon dock { get { return _allIcons["dock"]; } }
        public static MDLIcon gamepad { get { return _allIcons["gamepad"]; } }
        public static MDLIcon headset { get { return _allIcons["headset"]; } }
        public static MDLIcon headset_mic { get { return _allIcons["headset mic"]; } }
        public static MDLIcon keyboard { get { return _allIcons["keyboard"]; } }
        public static MDLIcon keyboard_arrow_down { get { return _allIcons["keyboard arrow down"]; } }
        public static MDLIcon keyboard_arrow_left { get { return _allIcons["keyboard arrow left"]; } }
        public static MDLIcon keyboard_arrow_right { get { return _allIcons["keyboard arrow right"]; } }
        public static MDLIcon keyboard_arrow_up { get { return _allIcons["keyboard arrow up"]; } }
        public static MDLIcon keyboard_backspace { get { return _allIcons["keyboard backspace"]; } }
        public static MDLIcon keyboard_capslock { get { return _allIcons["keyboard capslock"]; } }
        public static MDLIcon keyboard_hide { get { return _allIcons["keyboard hide"]; } }
        public static MDLIcon keyboard_return { get { return _allIcons["keyboard return"]; } }
        public static MDLIcon keyboard_tab { get { return _allIcons["keyboard tab"]; } }
        public static MDLIcon keyboard_voice { get { return _allIcons["keyboard voice"]; } }
        public static MDLIcon laptop { get { return _allIcons["laptop"]; } }
        public static MDLIcon laptop_chromebook { get { return _allIcons["laptop chromebook"]; } }
        public static MDLIcon laptop_mac { get { return _allIcons["laptop mac"]; } }
        public static MDLIcon laptop_windows { get { return _allIcons["laptop windows"]; } }
        public static MDLIcon memory { get { return _allIcons["memory"]; } }
        public static MDLIcon mouse { get { return _allIcons["mouse"]; } }
        public static MDLIcon phone_android { get { return _allIcons["phone android"]; } }
        public static MDLIcon phone_iphone { get { return _allIcons["phone iphone"]; } }
        public static MDLIcon phonelink { get { return _allIcons["phonelink"]; } }
        public static MDLIcon phonelink_off { get { return _allIcons["phonelink off"]; } }
        public static MDLIcon power_input { get { return _allIcons["power input"]; } }
        public static MDLIcon router { get { return _allIcons["router"]; } }
        public static MDLIcon scanner { get { return _allIcons["scanner"]; } }
        public static MDLIcon security { get { return _allIcons["security"]; } }
        public static MDLIcon sim_card { get { return _allIcons["sim card"]; } }
        public static MDLIcon smartphone { get { return _allIcons["smartphone"]; } }
        public static MDLIcon speaker { get { return _allIcons["speaker"]; } }
        public static MDLIcon speaker_group { get { return _allIcons["speaker group"]; } }
        public static MDLIcon tablet { get { return _allIcons["tablet"]; } }
        public static MDLIcon tablet_android { get { return _allIcons["tablet android"]; } }
        public static MDLIcon tablet_mac { get { return _allIcons["tablet mac"]; } }
        public static MDLIcon toys { get { return _allIcons["toys"]; } }
        public static MDLIcon tv { get { return _allIcons["tv"]; } }
        public static MDLIcon videogame_asset { get { return _allIcons["videogame asset"]; } }
        public static MDLIcon watch { get { return _allIcons["watch"]; } }
        public static MDLIcon add_a_photo { get { return _allIcons["add a photo"]; } }
        public static MDLIcon add_to_photos { get { return _allIcons["add to photos"]; } }
        public static MDLIcon adjust { get { return _allIcons["adjust"]; } }
        public static MDLIcon assistant { get { return _allIcons["assistant"]; } }
        public static MDLIcon assistant_photo { get { return _allIcons["assistant photo"]; } }
        public static MDLIcon audiotrack { get { return _allIcons["audiotrack"]; } }
        public static MDLIcon blur_circular { get { return _allIcons["blur circular"]; } }
        public static MDLIcon blur_linear { get { return _allIcons["blur linear"]; } }
        public static MDLIcon blur_off { get { return _allIcons["blur off"]; } }
        public static MDLIcon blur_on { get { return _allIcons["blur on"]; } }
        public static MDLIcon brightness_1 { get { return _allIcons["brightness 1"]; } }
        public static MDLIcon brightness_2 { get { return _allIcons["brightness 2"]; } }
        public static MDLIcon brightness_3 { get { return _allIcons["brightness 3"]; } }
        public static MDLIcon brightness_4 { get { return _allIcons["brightness 4"]; } }
        public static MDLIcon brightness_5 { get { return _allIcons["brightness 5"]; } }
        public static MDLIcon brightness_6 { get { return _allIcons["brightness 6"]; } }
        public static MDLIcon brightness_7 { get { return _allIcons["brightness 7"]; } }
        public static MDLIcon broken_image { get { return _allIcons["broken image"]; } }
        public static MDLIcon brush { get { return _allIcons["brush"]; } }
        public static MDLIcon camera { get { return _allIcons["camera"]; } }
        public static MDLIcon camera_alt { get { return _allIcons["camera alt"]; } }
        public static MDLIcon camera_front { get { return _allIcons["camera front"]; } }
        public static MDLIcon camera_rear { get { return _allIcons["camera rear"]; } }
        public static MDLIcon camera_roll { get { return _allIcons["camera roll"]; } }
        public static MDLIcon center_focus_strong { get { return _allIcons["center focus strong"]; } }
        public static MDLIcon center_focus_weak { get { return _allIcons["center focus weak"]; } }
        public static MDLIcon collections { get { return _allIcons["collections"]; } }
        public static MDLIcon collections_bookmark { get { return _allIcons["collections bookmark"]; } }
        public static MDLIcon color_lens { get { return _allIcons["color lens"]; } }
        public static MDLIcon colorize { get { return _allIcons["colorize"]; } }
        public static MDLIcon compare { get { return _allIcons["compare"]; } }
        public static MDLIcon control_point { get { return _allIcons["control point"]; } }
        public static MDLIcon control_point_duplicate { get { return _allIcons["control point duplicate"]; } }
        public static MDLIcon crop { get { return _allIcons["crop"]; } }
        public static MDLIcon crop_16_9 { get { return _allIcons["crop 16 9"]; } }
        public static MDLIcon crop_3_2 { get { return _allIcons["crop 3 2"]; } }
        public static MDLIcon crop_5_4 { get { return _allIcons["crop 5 4"]; } }
        public static MDLIcon crop_7_5 { get { return _allIcons["crop 7 5"]; } }
        public static MDLIcon crop_din { get { return _allIcons["crop din"]; } }
        public static MDLIcon crop_free { get { return _allIcons["crop free"]; } }
        public static MDLIcon crop_landscape { get { return _allIcons["crop landscape"]; } }
        public static MDLIcon crop_original { get { return _allIcons["crop original"]; } }
        public static MDLIcon crop_portrait { get { return _allIcons["crop portrait"]; } }
        public static MDLIcon crop_rotate { get { return _allIcons["crop rotate"]; } }
        public static MDLIcon crop_square { get { return _allIcons["crop square"]; } }
        public static MDLIcon dehaze { get { return _allIcons["dehaze"]; } }
        public static MDLIcon details { get { return _allIcons["details"]; } }
        public static MDLIcon edit { get { return _allIcons["edit"]; } }
        public static MDLIcon exposure { get { return _allIcons["exposure"]; } }
        public static MDLIcon exposure_neg_1 { get { return _allIcons["exposure neg 1"]; } }
        public static MDLIcon exposure_neg_2 { get { return _allIcons["exposure neg 2"]; } }
        public static MDLIcon exposure_plus_1 { get { return _allIcons["exposure plus 1"]; } }
        public static MDLIcon exposure_plus_2 { get { return _allIcons["exposure plus 2"]; } }
        public static MDLIcon exposure_zero { get { return _allIcons["exposure zero"]; } }
        public static MDLIcon filter { get { return _allIcons["filter"]; } }
        public static MDLIcon filter_1 { get { return _allIcons["filter 1"]; } }
        public static MDLIcon filter_2 { get { return _allIcons["filter 2"]; } }
        public static MDLIcon filter_3 { get { return _allIcons["filter 3"]; } }
        public static MDLIcon filter_4 { get { return _allIcons["filter 4"]; } }
        public static MDLIcon filter_5 { get { return _allIcons["filter 5"]; } }
        public static MDLIcon filter_6 { get { return _allIcons["filter 6"]; } }
        public static MDLIcon filter_7 { get { return _allIcons["filter 7"]; } }
        public static MDLIcon filter_8 { get { return _allIcons["filter 8"]; } }
        public static MDLIcon filter_9 { get { return _allIcons["filter 9"]; } }
        public static MDLIcon filter_9_plus { get { return _allIcons["filter 9 plus"]; } }
        public static MDLIcon filter_b_and_w { get { return _allIcons["filter b and w"]; } }
        public static MDLIcon filter_center_focus { get { return _allIcons["filter center focus"]; } }
        public static MDLIcon filter_drama { get { return _allIcons["filter drama"]; } }
        public static MDLIcon filter_frames { get { return _allIcons["filter frames"]; } }
        public static MDLIcon filter_hdr { get { return _allIcons["filter hdr"]; } }
        public static MDLIcon filter_none { get { return _allIcons["filter none"]; } }
        public static MDLIcon filter_tilt_shift { get { return _allIcons["filter tilt shift"]; } }
        public static MDLIcon filter_vintage { get { return _allIcons["filter vintage"]; } }
        public static MDLIcon flare { get { return _allIcons["flare"]; } }
        public static MDLIcon flash_auto { get { return _allIcons["flash auto"]; } }
        public static MDLIcon flash_off { get { return _allIcons["flash off"]; } }
        public static MDLIcon flash_on { get { return _allIcons["flash on"]; } }
        public static MDLIcon flip { get { return _allIcons["flip"]; } }
        public static MDLIcon gradient { get { return _allIcons["gradient"]; } }
        public static MDLIcon grain { get { return _allIcons["grain"]; } }
        public static MDLIcon grid_off { get { return _allIcons["grid off"]; } }
        public static MDLIcon grid_on { get { return _allIcons["grid on"]; } }
        public static MDLIcon hdr_off { get { return _allIcons["hdr off"]; } }
        public static MDLIcon hdr_on { get { return _allIcons["hdr on"]; } }
        public static MDLIcon hdr_strong { get { return _allIcons["hdr strong"]; } }
        public static MDLIcon hdr_weak { get { return _allIcons["hdr weak"]; } }
        public static MDLIcon healing { get { return _allIcons["healing"]; } }
        public static MDLIcon image { get { return _allIcons["image"]; } }
        public static MDLIcon image_aspect_ratio { get { return _allIcons["image aspect ratio"]; } }
        public static MDLIcon iso { get { return _allIcons["iso"]; } }
        public static MDLIcon landscape { get { return _allIcons["landscape"]; } }
        public static MDLIcon leak_add { get { return _allIcons["leak add"]; } }
        public static MDLIcon leak_remove { get { return _allIcons["leak remove"]; } }
        public static MDLIcon lens { get { return _allIcons["lens"]; } }
        public static MDLIcon linked_camera { get { return _allIcons["linked camera"]; } }
        public static MDLIcon looks { get { return _allIcons["looks"]; } }
        public static MDLIcon looks_3 { get { return _allIcons["looks 3"]; } }
        public static MDLIcon looks_4 { get { return _allIcons["looks 4"]; } }
        public static MDLIcon looks_5 { get { return _allIcons["looks 5"]; } }
        public static MDLIcon looks_6 { get { return _allIcons["looks 6"]; } }
        public static MDLIcon looks_one { get { return _allIcons["looks one"]; } }
        public static MDLIcon looks_two { get { return _allIcons["looks two"]; } }
        public static MDLIcon loupe { get { return _allIcons["loupe"]; } }
        public static MDLIcon monochrome_photos { get { return _allIcons["monochrome photos"]; } }
        public static MDLIcon movie_creation { get { return _allIcons["movie creation"]; } }
        public static MDLIcon movie_filter { get { return _allIcons["movie filter"]; } }
        public static MDLIcon music_note { get { return _allIcons["music note"]; } }
        public static MDLIcon nature { get { return _allIcons["nature"]; } }
        public static MDLIcon nature_people { get { return _allIcons["nature people"]; } }
        public static MDLIcon navigate_before { get { return _allIcons["navigate before"]; } }
        public static MDLIcon navigate_next { get { return _allIcons["navigate next"]; } }
        public static MDLIcon palette { get { return _allIcons["palette"]; } }
        public static MDLIcon panorama { get { return _allIcons["panorama"]; } }
        public static MDLIcon panorama_fish_eye { get { return _allIcons["panorama fish eye"]; } }
        public static MDLIcon panorama_horizontal { get { return _allIcons["panorama horizontal"]; } }
        public static MDLIcon panorama_vertical { get { return _allIcons["panorama vertical"]; } }
        public static MDLIcon panorama_wide_angle { get { return _allIcons["panorama wide angle"]; } }
        public static MDLIcon photo { get { return _allIcons["photo"]; } }
        public static MDLIcon photo_album { get { return _allIcons["photo album"]; } }
        public static MDLIcon photo_camera { get { return _allIcons["photo camera"]; } }
        public static MDLIcon photo_filter { get { return _allIcons["photo filter"]; } }
        public static MDLIcon photo_library { get { return _allIcons["photo library"]; } }
        public static MDLIcon photo_size_select_actual { get { return _allIcons["photo size select actual"]; } }
        public static MDLIcon photo_size_select_large { get { return _allIcons["photo size select large"]; } }
        public static MDLIcon photo_size_select_small { get { return _allIcons["photo size select small"]; } }
        public static MDLIcon picture_as_pdf { get { return _allIcons["picture as pdf"]; } }
        public static MDLIcon portrait { get { return _allIcons["portrait"]; } }
        public static MDLIcon remove_red_eye { get { return _allIcons["remove red eye"]; } }
        public static MDLIcon rotate_90_degrees_ccw { get { return _allIcons["rotate 90 degrees ccw"]; } }
        public static MDLIcon rotate_left { get { return _allIcons["rotate left"]; } }
        public static MDLIcon rotate_right { get { return _allIcons["rotate right"]; } }
        public static MDLIcon slideshow { get { return _allIcons["slideshow"]; } }
        public static MDLIcon straighten { get { return _allIcons["straighten"]; } }
        public static MDLIcon style { get { return _allIcons["style"]; } }
        public static MDLIcon switch_camera { get { return _allIcons["switch camera"]; } }
        public static MDLIcon switch_video { get { return _allIcons["switch video"]; } }
        public static MDLIcon tag_faces { get { return _allIcons["tag faces"]; } }
        public static MDLIcon texture { get { return _allIcons["texture"]; } }
        public static MDLIcon timelapse { get { return _allIcons["timelapse"]; } }
        public static MDLIcon timer { get { return _allIcons["timer"]; } }
        public static MDLIcon timer_10 { get { return _allIcons["timer 10"]; } }
        public static MDLIcon timer_3 { get { return _allIcons["timer 3"]; } }
        public static MDLIcon timer_off { get { return _allIcons["timer off"]; } }
        public static MDLIcon tonality { get { return _allIcons["tonality"]; } }
        public static MDLIcon transform { get { return _allIcons["transform"]; } }
        public static MDLIcon tune { get { return _allIcons["tune"]; } }
        public static MDLIcon view_comfy { get { return _allIcons["view comfy"]; } }
        public static MDLIcon view_compact { get { return _allIcons["view compact"]; } }
        public static MDLIcon vignette { get { return _allIcons["vignette"]; } }
        public static MDLIcon wb_auto { get { return _allIcons["wb auto"]; } }
        public static MDLIcon wb_cloudy { get { return _allIcons["wb cloudy"]; } }
        public static MDLIcon wb_incandescent { get { return _allIcons["wb incandescent"]; } }
        public static MDLIcon wb_iridescent { get { return _allIcons["wb iridescent"]; } }
        public static MDLIcon wb_sunny { get { return _allIcons["wb sunny"]; } }
        public static MDLIcon add_location { get { return _allIcons["add location"]; } }
        public static MDLIcon beenhere { get { return _allIcons["beenhere"]; } }
        public static MDLIcon directions { get { return _allIcons["directions"]; } }
        public static MDLIcon directions_bike { get { return _allIcons["directions bike"]; } }
        public static MDLIcon directions_boat { get { return _allIcons["directions boat"]; } }
        public static MDLIcon directions_bus { get { return _allIcons["directions bus"]; } }
        public static MDLIcon directions_car { get { return _allIcons["directions car"]; } }
        public static MDLIcon directions_railway { get { return _allIcons["directions railway"]; } }
        public static MDLIcon directions_run { get { return _allIcons["directions run"]; } }
        public static MDLIcon directions_subway { get { return _allIcons["directions subway"]; } }
        public static MDLIcon directions_transit { get { return _allIcons["directions transit"]; } }
        public static MDLIcon directions_walk { get { return _allIcons["directions walk"]; } }
        public static MDLIcon edit_location { get { return _allIcons["edit location"]; } }
        public static MDLIcon flight { get { return _allIcons["flight"]; } }
        public static MDLIcon hotel { get { return _allIcons["hotel"]; } }
        public static MDLIcon layers { get { return _allIcons["layers"]; } }
        public static MDLIcon layers_clear { get { return _allIcons["layers clear"]; } }
        public static MDLIcon local_activity { get { return _allIcons["local activity"]; } }
        public static MDLIcon local_airport { get { return _allIcons["local airport"]; } }
        public static MDLIcon local_atm { get { return _allIcons["local atm"]; } }
        public static MDLIcon local_bar { get { return _allIcons["local bar"]; } }
        public static MDLIcon local_cafe { get { return _allIcons["local cafe"]; } }
        public static MDLIcon local_car_wash { get { return _allIcons["local car wash"]; } }
        public static MDLIcon local_convenience_store { get { return _allIcons["local convenience store"]; } }
        public static MDLIcon local_dining { get { return _allIcons["local dining"]; } }
        public static MDLIcon local_drink { get { return _allIcons["local drink"]; } }
        public static MDLIcon local_florist { get { return _allIcons["local florist"]; } }
        public static MDLIcon local_gas_station { get { return _allIcons["local gas station"]; } }
        public static MDLIcon local_grocery_store { get { return _allIcons["local grocery store"]; } }
        public static MDLIcon local_hospital { get { return _allIcons["local hospital"]; } }
        public static MDLIcon local_hotel { get { return _allIcons["local hotel"]; } }
        public static MDLIcon local_laundry_service { get { return _allIcons["local laundry service"]; } }
        public static MDLIcon local_library { get { return _allIcons["local library"]; } }
        public static MDLIcon local_mall { get { return _allIcons["local mall"]; } }
        public static MDLIcon local_movies { get { return _allIcons["local movies"]; } }
        public static MDLIcon local_offer { get { return _allIcons["local offer"]; } }
        public static MDLIcon local_parking { get { return _allIcons["local parking"]; } }
        public static MDLIcon local_pharmacy { get { return _allIcons["local pharmacy"]; } }
        public static MDLIcon local_phone { get { return _allIcons["local phone"]; } }
        public static MDLIcon local_pizza { get { return _allIcons["local pizza"]; } }
        public static MDLIcon local_play { get { return _allIcons["local play"]; } }
        public static MDLIcon local_post_office { get { return _allIcons["local post office"]; } }
        public static MDLIcon local_printshop { get { return _allIcons["local printshop"]; } }
        public static MDLIcon local_see { get { return _allIcons["local see"]; } }
        public static MDLIcon local_shipping { get { return _allIcons["local shipping"]; } }
        public static MDLIcon local_taxi { get { return _allIcons["local taxi"]; } }
        public static MDLIcon map { get { return _allIcons["map"]; } }
        public static MDLIcon my_location { get { return _allIcons["my location"]; } }
        public static MDLIcon navigation { get { return _allIcons["navigation"]; } }
        public static MDLIcon near_me { get { return _allIcons["near me"]; } }
        public static MDLIcon person_pin { get { return _allIcons["person pin"]; } }
        public static MDLIcon person_pin_circle { get { return _allIcons["person pin circle"]; } }
        public static MDLIcon pin_drop { get { return _allIcons["pin drop"]; } }
        public static MDLIcon place { get { return _allIcons["place"]; } }
        public static MDLIcon rate_review { get { return _allIcons["rate review"]; } }
        public static MDLIcon restaurant_menu { get { return _allIcons["restaurant menu"]; } }
        public static MDLIcon satellite { get { return _allIcons["satellite"]; } }
        public static MDLIcon store_mall_directory { get { return _allIcons["store mall directory"]; } }
        public static MDLIcon terrain { get { return _allIcons["terrain"]; } }
        public static MDLIcon traffic { get { return _allIcons["traffic"]; } }
        public static MDLIcon zoom_out_map { get { return _allIcons["zoom out map"]; } }
        public static MDLIcon apps { get { return _allIcons["apps"]; } }
        public static MDLIcon arrow_back { get { return _allIcons["arrow back"]; } }
        public static MDLIcon arrow_downward { get { return _allIcons["arrow downward"]; } }
        public static MDLIcon arrow_drop_down { get { return _allIcons["arrow drop down"]; } }
        public static MDLIcon arrow_drop_down_circle { get { return _allIcons["arrow drop down circle"]; } }
        public static MDLIcon arrow_drop_up { get { return _allIcons["arrow drop up"]; } }
        public static MDLIcon arrow_forward { get { return _allIcons["arrow forward"]; } }
        public static MDLIcon arrow_upward { get { return _allIcons["arrow upward"]; } }
        public static MDLIcon cancel { get { return _allIcons["cancel"]; } }
        public static MDLIcon check { get { return _allIcons["check"]; } }
        public static MDLIcon chevron_left { get { return _allIcons["chevron left"]; } }
        public static MDLIcon chevron_right { get { return _allIcons["chevron right"]; } }
        public static MDLIcon close { get { return _allIcons["close"]; } }
        public static MDLIcon expand_less { get { return _allIcons["expand less"]; } }
        public static MDLIcon expand_more { get { return _allIcons["expand more"]; } }
        public static MDLIcon fullscreen { get { return _allIcons["fullscreen"]; } }
        public static MDLIcon fullscreen_exit { get { return _allIcons["fullscreen exit"]; } }
        public static MDLIcon menu { get { return _allIcons["menu"]; } }
        public static MDLIcon more_horiz { get { return _allIcons["more horiz"]; } }
        public static MDLIcon more_vert { get { return _allIcons["more vert"]; } }
        public static MDLIcon refresh { get { return _allIcons["refresh"]; } }
        public static MDLIcon subdirectory_arrow_left { get { return _allIcons["subdirectory arrow left"]; } }
        public static MDLIcon subdirectory_arrow_right { get { return _allIcons["subdirectory arrow right"]; } }
        public static MDLIcon adb { get { return _allIcons["adb"]; } }
        public static MDLIcon airline_seat_flat { get { return _allIcons["airline seat flat"]; } }
        public static MDLIcon airline_seat_flat_angled { get { return _allIcons["airline seat flat angled"]; } }
        public static MDLIcon airline_seat_individual_suite { get { return _allIcons["airline seat individual suite"]; } }
        public static MDLIcon airline_seat_legroom_extra { get { return _allIcons["airline seat legroom extra"]; } }
        public static MDLIcon airline_seat_legroom_normal { get { return _allIcons["airline seat legroom normal"]; } }
        public static MDLIcon airline_seat_legroom_reduced { get { return _allIcons["airline seat legroom reduced"]; } }
        public static MDLIcon airline_seat_recline_extra { get { return _allIcons["airline seat recline extra"]; } }
        public static MDLIcon airline_seat_recline_normal { get { return _allIcons["airline seat recline normal"]; } }
        public static MDLIcon bluetooth_audio { get { return _allIcons["bluetooth audio"]; } }
        public static MDLIcon confirmation_number { get { return _allIcons["confirmation number"]; } }
        public static MDLIcon disc_full { get { return _allIcons["disc full"]; } }
        public static MDLIcon do_not_disturb { get { return _allIcons["do not disturb"]; } }
        public static MDLIcon do_not_disturb_alt { get { return _allIcons["do not disturb alt"]; } }
        public static MDLIcon drive_eta { get { return _allIcons["drive eta"]; } }
        public static MDLIcon enhanced_encryption { get { return _allIcons["enhanced encryption"]; } }
        public static MDLIcon event_available { get { return _allIcons["event available"]; } }
        public static MDLIcon event_busy { get { return _allIcons["event busy"]; } }
        public static MDLIcon event_note { get { return _allIcons["event note"]; } }
        public static MDLIcon folder_special { get { return _allIcons["folder special"]; } }
        public static MDLIcon live_tv { get { return _allIcons["live tv"]; } }
        public static MDLIcon mms { get { return _allIcons["mms"]; } }
        public static MDLIcon more { get { return _allIcons["more"]; } }
        public static MDLIcon network_check { get { return _allIcons["network check"]; } }
        public static MDLIcon network_locked { get { return _allIcons["network locked"]; } }
        public static MDLIcon no_encryption { get { return _allIcons["no encryption"]; } }
        public static MDLIcon ondemand_video { get { return _allIcons["ondemand video"]; } }
        public static MDLIcon personal_video { get { return _allIcons["personal video"]; } }
        public static MDLIcon phone_bluetooth_speaker { get { return _allIcons["phone bluetooth speaker"]; } }
        public static MDLIcon phone_forwarded { get { return _allIcons["phone forwarded"]; } }
        public static MDLIcon phone_in_talk { get { return _allIcons["phone in talk"]; } }
        public static MDLIcon phone_locked { get { return _allIcons["phone locked"]; } }
        public static MDLIcon phone_missed { get { return _allIcons["phone missed"]; } }
        public static MDLIcon phone_paused { get { return _allIcons["phone paused"]; } }
        public static MDLIcon power { get { return _allIcons["power"]; } }
        public static MDLIcon sd_card { get { return _allIcons["sd card"]; } }
        public static MDLIcon sim_card_alert { get { return _allIcons["sim card alert"]; } }
        public static MDLIcon sms { get { return _allIcons["sms"]; } }
        public static MDLIcon sms_failed { get { return _allIcons["sms failed"]; } }
        public static MDLIcon sync { get { return _allIcons["sync"]; } }
        public static MDLIcon sync_disabled { get { return _allIcons["sync disabled"]; } }
        public static MDLIcon sync_problem { get { return _allIcons["sync problem"]; } }
        public static MDLIcon system_update { get { return _allIcons["system update"]; } }
        public static MDLIcon tap_and_play { get { return _allIcons["tap and play"]; } }
        public static MDLIcon time_to_leave { get { return _allIcons["time to leave"]; } }
        public static MDLIcon vibration { get { return _allIcons["vibration"]; } }
        public static MDLIcon voice_chat { get { return _allIcons["voice chat"]; } }
        public static MDLIcon vpn_lock { get { return _allIcons["vpn lock"]; } }
        public static MDLIcon wc { get { return _allIcons["wc"]; } }
        public static MDLIcon wifi { get { return _allIcons["wifi"]; } }
        public static MDLIcon ac_unit { get { return _allIcons["ac unit"]; } }
        public static MDLIcon airport_shuttle { get { return _allIcons["airport shuttle"]; } }
        public static MDLIcon all_inclusive { get { return _allIcons["all inclusive"]; } }
        public static MDLIcon beach_access { get { return _allIcons["beach access"]; } }
        public static MDLIcon business_center { get { return _allIcons["business center"]; } }
        public static MDLIcon casino { get { return _allIcons["casino"]; } }
        public static MDLIcon child_care { get { return _allIcons["child care"]; } }
        public static MDLIcon child_friendly { get { return _allIcons["child friendly"]; } }
        public static MDLIcon fitness_center { get { return _allIcons["fitness center"]; } }
        public static MDLIcon free_breakfast { get { return _allIcons["free breakfast"]; } }
        public static MDLIcon golf_course { get { return _allIcons["golf course"]; } }
        public static MDLIcon hot_tub { get { return _allIcons["hot tub"]; } }
        public static MDLIcon kitchen { get { return _allIcons["kitchen"]; } }
        public static MDLIcon pool { get { return _allIcons["pool"]; } }
        public static MDLIcon room_service { get { return _allIcons["room service"]; } }
        public static MDLIcon rv_hookup { get { return _allIcons["rv hookup"]; } }
        public static MDLIcon smoke_free { get { return _allIcons["smoke free"]; } }
        public static MDLIcon smoking_rooms { get { return _allIcons["smoking rooms"]; } }
        public static MDLIcon spa { get { return _allIcons["spa"]; } }
        public static MDLIcon cake { get { return _allIcons["cake"]; } }
        public static MDLIcon domain { get { return _allIcons["domain"]; } }
        public static MDLIcon group { get { return _allIcons["group"]; } }
        public static MDLIcon group_add { get { return _allIcons["group add"]; } }
        public static MDLIcon location_city { get { return _allIcons["location city"]; } }
        public static MDLIcon mood { get { return _allIcons["mood"]; } }
        public static MDLIcon mood_bad { get { return _allIcons["mood bad"]; } }
        public static MDLIcon notifications { get { return _allIcons["notifications"]; } }
        public static MDLIcon notifications_active { get { return _allIcons["notifications active"]; } }
        public static MDLIcon notifications_none { get { return _allIcons["notifications none"]; } }
        public static MDLIcon notifications_off { get { return _allIcons["notifications off"]; } }
        public static MDLIcon notifications_paused { get { return _allIcons["notifications paused"]; } }
        public static MDLIcon pages { get { return _allIcons["pages"]; } }
        public static MDLIcon party_mode { get { return _allIcons["party mode"]; } }
        public static MDLIcon people { get { return _allIcons["people"]; } }
        public static MDLIcon people_outline { get { return _allIcons["people outline"]; } }
        public static MDLIcon person { get { return _allIcons["person"]; } }
        public static MDLIcon person_add { get { return _allIcons["person add"]; } }
        public static MDLIcon person_outline { get { return _allIcons["person outline"]; } }
        public static MDLIcon plus_one { get { return _allIcons["plus one"]; } }
        public static MDLIcon poll { get { return _allIcons["poll"]; } }
        public static MDLIcon @public { get { return _allIcons["public"]; } }
        public static MDLIcon school { get { return _allIcons["school"]; } }
        public static MDLIcon share { get { return _allIcons["share"]; } }
        public static MDLIcon whatshot { get { return _allIcons["whatshot"]; } }
        public static MDLIcon check_box { get { return _allIcons["check box"]; } }
        public static MDLIcon check_box_outline_blank { get { return _allIcons["check box outline blank"]; } }
        public static MDLIcon indeterminate_check_box { get { return _allIcons["indeterminate check box"]; } }
        public static MDLIcon radio_button_checked { get { return _allIcons["radio button checked"]; } }
        public static MDLIcon radio_button_unchecked { get { return _allIcons["radio button unchecked"]; } }
        public static MDLIcon star { get { return _allIcons["star"]; } }
        public static MDLIcon star_border { get { return _allIcons["star border"]; } }
        public static MDLIcon star_half { get { return _allIcons["star half"]; } }


        public static IEnumerable<MDLIcon> All { get { return _allIcons.Values; } }

    }
}