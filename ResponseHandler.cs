namespace CybersecurityAwarenessBot
{
    public static class ResponseHandler
    {
        public static string GetResponse(string input, string name)
        {
            if (input.Contains("how are you") || input.Contains("hi") || input.Contains("hello"))
                return $"I'm doing fantastic, {name}! Thanks for asking. How can I help you stay safe online today?";

            if (input.Contains("purpose") || input.Contains("who are you"))
                return $"I'm the Cybersecurity Awareness Assistant for South African citizens, {name}. My job is to educate you about online threats like phishing, weak passwords, and suspicious links.";

            if (input.Contains("phishing"))
                return "Phishing is one of the biggest threats in South Africa. Attackers send fake emails or messages pretending to be banks or government. Never click suspicious links. Always verify the sender and report to the South African Police Service Cybercrimes Unit.";

            if (input.Contains("password"))
                return $"Strong passwords are your first line of defence, {name}! Use at least 12 characters with uppercase, lowercase, numbers and symbols. Never reuse passwords. Enable 2FA everywhere.";

            if (input.Contains("2fa") || input.Contains("two factor"))
                return "Two-Factor Authentication (2FA) is essential. Even if your password is stolen, the attacker still needs your phone or authenticator app. Always turn it on!";

            if (input.Contains("safe browsing") || input.Contains("link"))
                return "Safe browsing tips: Only visit sites starting with https://, avoid public Wi-Fi for banking, keep your software updated, and install reputable antivirus software.";

            if (input.Contains("cybersecurity"))
                return "Cybersecurity is the practice of protecting computers, networks, and data from digital attacks. In South Africa it is now a national priority because of the sharp rise in cyberattacks.";

            // Default response
            return $"Great question, {name}! I didn't have an exact answer for that one. Try asking about phishing, passwords, 2FA, or safe browsing. I'm here to help!";
        }
    }
}