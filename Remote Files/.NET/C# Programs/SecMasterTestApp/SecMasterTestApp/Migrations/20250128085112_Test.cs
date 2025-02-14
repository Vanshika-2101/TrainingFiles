using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecMasterTestApp.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateSequence<int>(
            //    name: "Bond_Pricing_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Bond_risk_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Bond_Schedule_type_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Bond_security_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Bond_Summary_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Entity_Summary_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Equity_Dividend_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Equity_Pricing_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Equity_Reference_data_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Equity_risk_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Equity_security_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Identifier_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Identifier_type_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Pricing_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Reference_data_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Regulatory_details_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Schedule_type_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "Security_type_id_Sequence");

            //migrationBuilder.CreateSequence<int>(
            //    name: "SecurityID_Sequence");

            //migrationBuilder.CreateTable(
            //    name: "Bond_Schedule_type",
            //    columns: table => new
            //    {
            //        schedule_type_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Schedule_type_Sequence])"),
            //        schedule_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Bond_Sch__C4D44B8B038A7F60", x => x.schedule_type_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Identifier_Types",
            //    columns: table => new
            //    {
            //        identifier_type_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Identifier_type_Sequence])"),
            //        identifier_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Identifi__0CA15AA27DF812D5", x => x.identifier_type_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Security_types",
            //    columns: table => new
            //    {
            //        security_type_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Security_type_id_Sequence])"),
            //        security_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Security__4EE38F369F7DC877", x => x.security_type_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Securities",
            //    columns: table => new
            //    {
            //        security_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [SecurityID_Sequence])"),
            //        security_type = table.Column<int>(type: "int", nullable: false),
            //        security_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        is_active = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Securiti__46647BD1C6BC2815", x => x.security_id);
            //        table.ForeignKey(
            //            name: "FK__Securitie__secur__4CA06362",
            //            column: x => x.security_type,
            //            principalTable: "Security_types",
            //            principalColumn: "security_type_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Bond_Risk",
            //    columns: table => new
            //    {
            //        bond_risk_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Bond_risk_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: false),
            //        duration = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
            //        volatility_30d = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        volatility_90d = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        convexity = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
            //        average_vol_30d = table.Column<decimal>(type: "decimal(18,9)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Bond_Ris__0C9B4377C6A75968", x => x.bond_risk_id);
            //        table.ForeignKey(
            //            name: "FK__Bond_Risk__secur__5DCAEF64",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Bond_Schedules",
            //    columns: table => new
            //    {
            //        schedule_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Bond_Schedule_type_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: true),
            //        schedule_type = table.Column<int>(type: "int", nullable: true),
            //        schedule_price = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        schedule_date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Bond_Sch__C46A8A6FA49BCBD0", x => x.schedule_id);
            //        table.ForeignKey(
            //            name: "FK__Bond_Sche__sched__10566F31",
            //            column: x => x.schedule_type,
            //            principalTable: "Bond_Schedule_type",
            //            principalColumn: "schedule_type_id");
            //        table.ForeignKey(
            //            name: "FK__Bond_Sche__secur__0F624AF8",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Bond_Security_Details",
            //    columns: table => new
            //    {
            //        bond_security_detail_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Bond_security_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: false),
            //        first_coupon_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        coupon_cap = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        coupon_floor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        coupon_frequency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        coupon_rate = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        coupon_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        is_callable = table.Column<bool>(type: "bit", nullable: true),
            //        is_fix_to_float = table.Column<bool>(type: "bit", nullable: true),
            //        is_putable = table.Column<bool>(type: "bit", nullable: true),
            //        issue_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        last_reset_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        maturity_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        max_call_notice_days = table.Column<int>(type: "int", nullable: true),
            //        max_put_notice_days = table.Column<int>(type: "int", nullable: true),
            //        pen_coupon_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        reset_frequency = table.Column<int>(type: "int", nullable: true),
            //        has_position = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Bond_Sec__5AA954FAE7B2CDEB", x => x.bond_security_detail_id);
            //        table.ForeignKey(
            //            name: "FK__Bond_Secu__secur__6E01572D",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Bonds_Security_Summary",
            //    columns: table => new
            //    {
            //        bond_security_summary_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Bond_Summary_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: true),
            //        investment_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        trading_factor = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        pricing_factor = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        asset_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Bonds_Se__2932B7603E13A3D3", x => x.bond_security_summary_id);
            //        table.ForeignKey(
            //            name: "FK__Bonds_Sec__secur__5629CD9C",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Equities_Security_Summary",
            //    columns: table => new
            //    {
            //        equity_security_summary_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Entity_Summary_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: true),
            //        has_position = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
            //        round_lot_size = table.Column<int>(type: "int", nullable: true),
            //        bloomberg_unique_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Equities__A94CF7D5668EC77B", x => x.equity_security_summary_id);
            //        table.ForeignKey(
            //            name: "FK__Equities___secur__5165187F",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Equity_Dividend_History",
            //    columns: table => new
            //    {
            //        dividend_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Equity_Dividend_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: false),
            //        declared_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ex_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        record_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        pay_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        amount = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        frequency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        dividend_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Equity_D__7635F10C4475E724", x => x.dividend_id);
            //        table.ForeignKey(
            //            name: "FK__Equity_Di__secur__08B54D69",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Equity_Risk",
            //    columns: table => new
            //    {
            //        equity_risk_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Equity_risk_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: false),
            //        average_volume_20d = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
            //        beta = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
            //        short_interest = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
            //        ytd_return = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
            //        volatility_90d = table.Column<decimal>(type: "decimal(18,9)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Equity_R__9121C4491F12451E", x => x.equity_risk_id);
            //        table.ForeignKey(
            //            name: "FK__Equity_Ri__secur__59FA5E80",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Equity_Security_Details",
            //    columns: table => new
            //    {
            //        equity_security_detail_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Equity_security_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: false),
            //        adr_underlying_ticker = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        adr_underlying_currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        shares_per_adr = table.Column<int>(type: "int", nullable: true),
            //        ipo_date = table.Column<DateOnly>(type: "date", nullable: true),
            //        price_currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        settle_days = table.Column<int>(type: "int", nullable: true),
            //        outstanding_shares = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        vote_right_per_share = table.Column<decimal>(type: "decimal(18,9)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Equity_S__983EF8452F191EF2", x => x.equity_security_detail_id);
            //        table.ForeignKey(
            //            name: "FK__Equity_Se__secur__6A30C649",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Identifiers",
            //    columns: table => new
            //    {
            //        identifier_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Identifier_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: false),
            //        idenitifer_type = table.Column<int>(type: "int", nullable: false),
            //        identifier_value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Identifi__57C4F6DC63CBAF16", x => x.identifier_id);
            //        table.ForeignKey(
            //            name: "FK__Identifie__ideni__66603565",
            //            column: x => x.idenitifer_type,
            //            principalTable: "Identifier_Types",
            //            principalColumn: "identifier_type_id");
            //        table.ForeignKey(
            //            name: "FK__Identifie__secur__656C112C",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Pricing_Details",
            //    columns: table => new
            //    {
            //        pricing_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Pricing_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: false),
            //        open_price = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        last_price = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        ask_price = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        bid_price = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        volume = table.Column<decimal>(type: "decimal(18,9)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Pricing___A25A9FB70BB56EF8", x => x.pricing_id);
            //        table.ForeignKey(
            //            name: "FK__Pricing_D__secur__7D439ABD",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Reference_Data",
            //    columns: table => new
            //    {
            //        reference_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Reference_data_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: false),
            //        issuer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        issuer_country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        issue_currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        bloomberg_sector = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        bloomberg_group = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        bloomber_subGroup = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Referenc__8E860B28AA867DB0", x => x.reference_id);
            //        table.ForeignKey(
            //            name: "FK__Reference__secur__75A278F5",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Regulatory_Details",
            //    columns: table => new
            //    {
            //        regulatory_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Regulatory_details_Sequence])"),
            //        security_id = table.Column<int>(type: "int", nullable: false),
            //        pf_asset_class = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pf_country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pf_credit_rating = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pf_currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pf_instrument = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pf_liquidity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pf_maturity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pf_NAICS_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pf_region = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pf_sector = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pf_sub_asset_class = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Regulato__CE5849C94D9A2623", x => x.regulatory_id);
            //        table.ForeignKey(
            //            name: "FK__Regulator__secur__71D1E811",
            //            column: x => x.security_id,
            //            principalTable: "Securities",
            //            principalColumn: "security_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Bond_Pricing_Details",
            //    columns: table => new
            //    {
            //        bond_pricing_details_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Bond_Pricing_Sequence])"),
            //        pricing_details_id = table.Column<int>(type: "int", nullable: false),
            //        high_price = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        low_price = table.Column<decimal>(type: "decimal(18,9)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Bond_Pri__FF889DA12D0FBC2E", x => x.bond_pricing_details_id);
            //        table.ForeignKey(
            //            name: "FK__Bond_Pric__prici__04E4BC85",
            //            column: x => x.pricing_details_id,
            //            principalTable: "Pricing_Details",
            //            principalColumn: "pricing_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Equity_Pricing_Details",
            //    columns: table => new
            //    {
            //        equity_pricing_details_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Equity_Pricing_Sequence])"),
            //        pricing_details_id = table.Column<int>(type: "int", nullable: false),
            //        close_price = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
            //        pe_ration = table.Column<decimal>(type: "decimal(18,9)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Equity_P__0E56F0FB01FD87C3", x => x.equity_pricing_details_id);
            //        table.ForeignKey(
            //            name: "FK__Equity_Pr__prici__01142BA1",
            //            column: x => x.pricing_details_id,
            //            principalTable: "Pricing_Details",
            //            principalColumn: "pricing_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Equity_reference_data",
            //    columns: table => new
            //    {
            //        equity_reference_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR [Equity_Reference_data_Sequence])"),
            //        reference_id = table.Column<int>(type: "int", nullable: false),
            //        exchange = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        trading_currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Equity_r__E294D24573C29034", x => x.equity_reference_id);
            //        table.ForeignKey(
            //            name: "FK__Equity_re__refer__797309D9",
            //            column: x => x.reference_id,
            //            principalTable: "Reference_Data",
            //            principalColumn: "reference_id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Bond_Pricing_Details_pricing_details_id",
            //    table: "Bond_Pricing_Details",
            //    column: "pricing_details_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Bond_Risk_security_id",
            //    table: "Bond_Risk",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Bond_Schedules_schedule_type",
            //    table: "Bond_Schedules",
            //    column: "schedule_type");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Bond_Schedules_security_id",
            //    table: "Bond_Schedules",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Bond_Security_Details_security_id",
            //    table: "Bond_Security_Details",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Bonds_Security_Summary_security_id",
            //    table: "Bonds_Security_Summary",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Equities_Security_Summary_security_id",
            //    table: "Equities_Security_Summary",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Equity_Dividend_History_security_id",
            //    table: "Equity_Dividend_History",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Equity_Pricing_Details_pricing_details_id",
            //    table: "Equity_Pricing_Details",
            //    column: "pricing_details_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Equity_reference_data_reference_id",
            //    table: "Equity_reference_data",
            //    column: "reference_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Equity_Risk_security_id",
            //    table: "Equity_Risk",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Equity_Security_Details_security_id",
            //    table: "Equity_Security_Details",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Identifiers_idenitifer_type",
            //    table: "Identifiers",
            //    column: "idenitifer_type");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Identifiers_security_id",
            //    table: "Identifiers",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Pricing_Details_security_id",
            //    table: "Pricing_Details",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Reference_Data_security_id",
            //    table: "Reference_Data",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Regulatory_Details_security_id",
            //    table: "Regulatory_Details",
            //    column: "security_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Securities_security_type",
            //    table: "Securities",
            //    column: "security_type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bond_Pricing_Details");

            migrationBuilder.DropTable(
                name: "Bond_Risk");

            migrationBuilder.DropTable(
                name: "Bond_Schedules");

            migrationBuilder.DropTable(
                name: "Bond_Security_Details");

            migrationBuilder.DropTable(
                name: "Bonds_Security_Summary");

            migrationBuilder.DropTable(
                name: "Equities_Security_Summary");

            migrationBuilder.DropTable(
                name: "Equity_Dividend_History");

            migrationBuilder.DropTable(
                name: "Equity_Pricing_Details");

            migrationBuilder.DropTable(
                name: "Equity_reference_data");

            migrationBuilder.DropTable(
                name: "Equity_Risk");

            migrationBuilder.DropTable(
                name: "Equity_Security_Details");

            migrationBuilder.DropTable(
                name: "Identifiers");

            migrationBuilder.DropTable(
                name: "Regulatory_Details");

            migrationBuilder.DropTable(
                name: "Bond_Schedule_type");

            migrationBuilder.DropTable(
                name: "Pricing_Details");

            migrationBuilder.DropTable(
                name: "Reference_Data");

            migrationBuilder.DropTable(
                name: "Identifier_Types");

            migrationBuilder.DropTable(
                name: "Securities");

            migrationBuilder.DropTable(
                name: "Security_types");

            migrationBuilder.DropSequence(
                name: "Bond_Pricing_Sequence");

            migrationBuilder.DropSequence(
                name: "Bond_risk_Sequence");

            migrationBuilder.DropSequence(
                name: "Bond_Schedule_type_Sequence");

            migrationBuilder.DropSequence(
                name: "Bond_security_Sequence");

            migrationBuilder.DropSequence(
                name: "Bond_Summary_Sequence");

            migrationBuilder.DropSequence(
                name: "Entity_Summary_Sequence");

            migrationBuilder.DropSequence(
                name: "Equity_Dividend_Sequence");

            migrationBuilder.DropSequence(
                name: "Equity_Pricing_Sequence");

            migrationBuilder.DropSequence(
                name: "Equity_Reference_data_Sequence");

            migrationBuilder.DropSequence(
                name: "Equity_risk_Sequence");

            migrationBuilder.DropSequence(
                name: "Equity_security_Sequence");

            migrationBuilder.DropSequence(
                name: "Identifier_Sequence");

            migrationBuilder.DropSequence(
                name: "Identifier_type_Sequence");

            migrationBuilder.DropSequence(
                name: "Pricing_Sequence");

            migrationBuilder.DropSequence(
                name: "Reference_data_Sequence");

            migrationBuilder.DropSequence(
                name: "Regulatory_details_Sequence");

            migrationBuilder.DropSequence(
                name: "Schedule_type_Sequence");

            migrationBuilder.DropSequence(
                name: "Security_type_id_Sequence");

            migrationBuilder.DropSequence(
                name: "SecurityID_Sequence");
        }
    }
}
