/* -----------------------------------------------------------------------------
 * Displayer.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Tue Apr 09 16:49:04 PDT 2019
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;

public class Displayer:Visitor
{

  public Object Visit(Rule_did rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_did_method rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_did_root rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_method rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_methodchar rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_method_specific_idstring rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_idstring rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_idchar rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_did_uri rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_did_optional_transform rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_did_method_transform rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_did_root_transform rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_transform rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_transformer rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_transformer_namedvalue rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_transformer_quotedvalue rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_transformer_numericvalue rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_transformer_option rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_transformer_stringvalue rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_transformer_char rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_transform_char rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_generic_option rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_transformer_options rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_URI rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_hier_part rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_scheme rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_authority rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_userinfo rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_host rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_port rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_IP_literal rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_IPvFuture rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_IPv6address rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_h16 rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_ls32 rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_IPv4address rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_dec_octet rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_reg_name rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_path_abempty rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_path_absolute rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_path_rootless rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_segment rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_segment_nz rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_pchar rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_query rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_fragment rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_pct_encoded rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_unreserved rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_sub_delims rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_other_delims rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_pchar_no_SQUOTE rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_pct_encoded_no_SQUOTE rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_qchar_no_AMP rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_qchar_no_AMP_EQ rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_qchar_no_AMP_EQ_AT_DOLLAR rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_ALPHA rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_DIGIT rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_HEXDIG rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_A_to_F rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_DQUOTE rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_SP rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_HTAB rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_VCHAR rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Terminal_StringValue value)
  {
    ////Console.Write(value.spelling);
    return null;
  }

  public Object Visit(Terminal_NumericValue value)
  {
    ////Console.Write(value.spelling);
    return null;
  }

    static int level = 0;
  private Object VisitRules(List<Rule> rules)
  {
        level++;
        foreach (Rule rule in rules)
        {
            string type = rule.GetType().ToString();
            if (!type.StartsWith("Terminal_")
                && !type.Equals("Rule_DIGIT")
                && !type.Equals("Rule_ALPHA")
                && !type.Equals("Rule_pchar")
                && !type.Equals("Rule_unreserved")
                && !type.Equals("Rule_transformer_char")
                && !type.Equals("Rule_other_delims")
                && !type.Equals("Rule_methodchar")
                && !type.Equals("Rule_idchar"))
            {
                Console.WriteLine($"{level}{":".PadRight(level, ' ')}{rule.ToString()}\t{rule.GetType().ToString()}");
            }
            rule.Accept(this);
        }
        level--;
        return null;
  }
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
