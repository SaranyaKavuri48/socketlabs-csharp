﻿namespace SocketLabs.InjectionApi
{
    /// <summary>
    /// The response of an SocketLabsClient send request.
    /// </summary>
    public class SendResponse
    {
        /// <summary>
        /// The result of the SocketLabsClient send request. 
        /// </summary>
        public SendResult Result { get; set; }

        /// <summary>
        /// A unique key generated by the Injection API if an unexpected error occurs during the SocketLabsClient send request.
        /// This unique key can be used by SocketLabs support to troubleshoot the issue.
        /// </summary>
        public string TransactionReceipt { get; set; }

        /// <summary>
        /// An array of AddressResult objects that contain the status of each address that failed. If no messages failed this array is empty.
        /// </summary>
        public AddressResult[] AddressResults { get; set; }

        /// <summary>
        /// A message detailing why the SocketLabsClient send request failed.
        /// </summary>
        public string ResponseMessage
        {
            get
            {

                switch (Result)
                {
                    case SendResult.UnknownError:
                        return "An error has occured that was unforeseen";

                    case SendResult.Timeout:
                        return "A timeout occurred sending the message";

                  

                    case SendResult.Success:
                        return "Successful send of message";

                    case SendResult.Warning:
                        return "Warnings were found while sending the message";

                    case SendResult.InternalError:
                        return "Internal server error";

                    case SendResult.MessageTooLarge:
                        return "Message size has exceeded the size limit";

                    case SendResult.TooManyRecipients:
                        return "Message exceeded maximum recipient count in the message";

                    case SendResult.InvalidData:
                        return "Invalid data was found on the message";

                    case SendResult.OverQuota:
                        return "The account is over the send quota, rate limit exceeded";

                    case SendResult.TooManyErrors:
                        return "Too many errors occurred sending the message";

                    case SendResult.InvalidAuthentication:
                        return "The ServerId/ApiKey combination is invalid";

                    case SendResult.AccountDisabled:
                        return "The account has been disabled";

                    case SendResult.TooManyMessages:
                        return "Too many messages were found in the request";

                    case SendResult.NoValidRecipients:
                        return "No valid recipients were found in the message";

                    case SendResult.InvalidAddress:
                        return "An invalid recipient were found on the message";

                    case SendResult.InvalidAttachment:
                        return "An invalid attachment were found on the message";

                    case SendResult.NoMessages:
                        return "No message body was found in the message";

                    case SendResult.EmptyMessage:
                        return "No message body was found in the message";

                    case SendResult.EmptySubject:
                        return "No subject was found in the message";

                    case SendResult.InvalidFrom:
                        return "An invalid from address was found on the message";

                    case SendResult.EmptyToAddress:
                        return "No To addresses were found in the message";

                    case SendResult.NoValidBodyParts:
                        return "No valid message body was found in the message";

                    case SendResult.InvalidTemplateId:
                        return "An invalid TemplateId was found in the message";

                    case SendResult.TemplateHasNoContent:
                        return "The specified TemplateId has no content for the message";

                    case SendResult.MessageBodyConflict:
                        return "A conflict occurred on the message body of the message";

                    case SendResult.InvalidMergeData:
                        return "Invalid MergeData was found on the message";

                    case SendResult.AuthenticationValidationFailed:
                        return "SDK Validation Error : Authentication Validation Failed, Missing or invalid ServerId or ApiKey";

                    case SendResult.RecipientValidationMaxExceeded:
                        return "SDK Validation Error : Message exceeded maximum recipient count in the message";

                    case SendResult.RecipientValidationNoneInMessage:
                        return "SDK Validation Error : No Recipients were found in the message";

                    case SendResult.EmailAddressValidationMissingFrom:
                        return "SDK Validation Error : From email address is missing in the message";

                    case SendResult.RecipientValidationMissingTo:
                        return "SDK Validation Error : To addresses are missing in the message";

                    case SendResult.EmailAddressValidationInvalidFrom:
                        return "SDK Validation Error : From email address in the message is invalid";

                    case SendResult.MessageValidationEmptySubject:
                        return "SDK Validation Error : No Subject was found in the message";

                    case SendResult.MessageValidationEmptyMessage:
                        return "SDK Validation Error : No message body was found in the message";

                    case SendResult.MessageValidationInvalidCustomHeaders:
                        return "SDK Validation Error : Invalid Custom Headers were found in the message";

                    case SendResult.RecipientValidationInvalidReplyTo:
                        return "SDK Validation Error : Invalid ReplyTo Address was found in the message";

                    case SendResult.RecipientValidationInvalidRecipients:
                        return "SDK Validation Error : Invalid recipients were found in the message";

                    default:
                        return "";

                }
            }
        }

        /// <summary>
        /// Represents the <c>SendResponse</c> as a string.  Useful for debugging.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Result.ToString()}: {ResponseMessage}";
        }
    }
}