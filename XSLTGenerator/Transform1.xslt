<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="xml" indent="yes"/>
  
  

  <xsl:template match="/TransformObject">
    <xsl:variable name="DataSetName">
      <xsl:value-of select="DataSetName"  disable-output-escaping="yes"/>
    </xsl:variable>
    <xsl:variable name="Title">
      <xsl:value-of select="Title"  disable-output-escaping="yes"/>
    </xsl:variable>
    <Report xmlns:rd="http://schemas.microsoft.com/SQLServer/reporting/reportdesigner" xmlns:cl="http://schemas.microsoft.com/sqlserver/reporting/2010/01/componentdefinition" xmlns="http://schemas.microsoft.com/sqlserver/reporting/2010/01/reportdefinition">
      <AutoRefresh>0</AutoRefresh>
      <DataSources>
        <DataSource Name="UTrackDB">
          <DataSourceReference>UTrackDatabaseDatasource</DataSourceReference>
          <rd:SecurityType>None</rd:SecurityType>
          <rd:DataSourceID>beeedc78-2278-4a35-9aa5-33fa709886b1</rd:DataSourceID>
        </DataSource>
      </DataSources>
      <DataSets>
        <DataSet Name="{$DataSetName}">
          <SharedDataSet>
            <SharedDataSetReference>
              <xsl:value-of select="$DataSetName"  disable-output-escaping="yes"/>
            </SharedDataSetReference>
            <QueryParameters>
              <QueryParameter Name="@DataSetName">
                <Value>=Parameters!DataSetName.Value</Value>
                <rd:UserDefined>true</rd:UserDefined>
              </QueryParameter>
              <QueryParameter Name="@QueryID">
                <Value>=Parameters!QueryID.Value</Value>
                <rd:UserDefined>true</rd:UserDefined>
              </QueryParameter>
              <QueryParameter Name="@ScheduledReportId">
                <Value>=Parameters!ScheduledReportId.Value</Value>
                <rd:UserDefined>true</rd:UserDefined>
              </QueryParameter>
            </QueryParameters>
          </SharedDataSet>
          <Fields>
            <xsl:for-each select="Fields/FieldDef">

              <xsl:variable name="FieldName">
                <xsl:value-of select="Name"  disable-output-escaping="yes"/>
              </xsl:variable>
              <Field Name="{$FieldName}">
                <DataField>
                  <xsl:value-of select="$FieldName"  disable-output-escaping="yes"/>
                </DataField>
                <rd:TypeName>
                  <xsl:value-of select="TypeName"  disable-output-escaping="yes"/>
                </rd:TypeName>
                <rd:UserDefined>true</rd:UserDefined>
              </Field>
            </xsl:for-each>
          </Fields>
        </DataSet>
        <DataSet Name="Conditions">
          <SharedDataSet>
            <SharedDataSetReference>Conditions</SharedDataSetReference>
            <QueryParameters>
              <QueryParameter Name="@QueryId">
                <Value>=Parameters!QueryID.Value</Value>
              </QueryParameter>
              <QueryParameter Name="@UseDelimiter">
                <Value>0</Value>
              </QueryParameter>
            </QueryParameters>
          </SharedDataSet>
          <Fields>
            <Field Name="WhereString">
              <DataField>WhereString</DataField>
              <rd:TypeName>System.String</rd:TypeName>
            </Field>
          </Fields>
        </DataSet>
      </DataSets>
      
      <ReportSections>
        <ReportSection>
          <Body>

            <ReportItems>
              <Textbox Name="Textbox1">
                <CanGrow>true</CanGrow>
                <KeepTogether>true</KeepTogether>
                <Paragraphs>
                  <Paragraph>
                    <TextRuns>
                      <TextRun>
                        <Label>Conditions</Label>
                        <Value>=First(Fields!WhereString.Value, "Conditions")</Value>
                        <MarkupType>HTML</MarkupType>
                        <Style>
                          <FontSize>12pt</FontSize>
                        </Style>
                      </TextRun>
                    </TextRuns>
                    <Style />
                  </Paragraph>
                </Paragraphs>
                <rd:DefaultName>Textbox1</rd:DefaultName>
                <Top>0in</Top>
                <Height>0.45in</Height>
                <Width>
                  <xsl:value-of select="TotalWidth"/>in
                </Width>
                <ZIndex>1</ZIndex>
                <Style>
                  <Border>
                    <Style>None</Style>
                  </Border>
                  <BackgroundColor>#b8cce4</BackgroundColor>
                  <VerticalAlign>Middle</VerticalAlign>
                  <PaddingLeft>2pt</PaddingLeft>
                  <PaddingRight>2pt</PaddingRight>
                  <PaddingTop>2pt</PaddingTop>
                  <PaddingBottom>2pt</PaddingBottom>
                </Style>
              </Textbox>
              <Tablix Name="Tablix4">
                <TablixBody>
                  <TablixColumns>
                    <xsl:for-each select="Fields/FieldDef">
                      <TablixColumn>
                        <Width><xsl:value-of select="Width"/>in</Width>
                      </TablixColumn>
                    </xsl:for-each>
                  </TablixColumns>

                  <TablixRows>
                    <TablixRow>
                      <Height>0.35in</Height>
                      <TablixCells>
                        <xsl:for-each select="Fields/FieldDef">
                          <xsl:variable name="tbName">
                            <xsl:value-of select="Name"  disable-output-escaping="yes"/>
                          </xsl:variable>
                          <TablixCell>
                            <CellContents>
                              <Textbox Name="Textbox_{$tbName}">
                                <CanGrow>true</CanGrow>
                                <KeepTogether>true</KeepTogether>
                                <Paragraphs>
                                  <Paragraph>
                                    <TextRuns>
                                      <TextRun>
                                        <Value>
                                          <xsl:value-of select="Title" />
                                        </Value>
                                        <Style>
                                          <FontFamily>Arial</FontFamily>
                                          <FontSize>8.25pt</FontSize>
                                          <FontWeight>Bold</FontWeight>
                                          <Color>Black</Color>
                                        </Style>
                                      </TextRun>
                                    </TextRuns>
                                    <Style />
                                  </Paragraph>
                                </Paragraphs>
                                <rd:DefaultName>
                                  Textbox_<xsl:value-of select="$tbName"/>
                                </rd:DefaultName>
                                <Style>
                                  <Border>
                                    <Style>Solid</Style>
                                    <Color>#8f9eaf</Color>
                                    <Width>0.75pt</Width>
                                  </Border>
                                  <BottomBorder>
                                    <Style>Solid</Style>
                                    <Color>#657a91</Color>
                                    <Width>2.25pt</Width>
                                  </BottomBorder>
                                  <BackgroundColor>#afb8c1</BackgroundColor>
                                  <PaddingLeft>2pt</PaddingLeft>
                                  <PaddingRight>2pt</PaddingRight>
                                  <PaddingTop>2pt</PaddingTop>
                                  <PaddingBottom>2pt</PaddingBottom>
                                </Style>
                              </Textbox>
                            </CellContents>
                          </TablixCell>
                        </xsl:for-each>
                      </TablixCells>
                    </TablixRow>

                    <TablixRow>
                      <Height>0.25in</Height>
                      <TablixCells>
                        <xsl:for-each select="Fields/FieldDef">
                          <xsl:variable name="tbName">
                            <xsl:value-of select="Name"  disable-output-escaping="yes"/>
                          </xsl:variable>
                          <TablixCell>
                            <CellContents>
                              <Textbox Name="{$tbName}">
                                <CanGrow>true</CanGrow>
                                <KeepTogether>true</KeepTogether>
                                <Paragraphs>
                                  <Paragraph>
                                    <TextRuns>
                                      <TextRun>
                                        <Value>
                                          <xsl:choose>
                                            <xsl:when test="CalculatedField != ''">
                                                =<xsl:value-of select="CalculatedField" />
                                            </xsl:when>
                                            <xsl:when test="CustomFunction != ''">
                                              =<xsl:value-of select="CustomFunction" />(Fields!<xsl:value-of select="$tbName"/>.Value)
                                            </xsl:when>
                                            <xsl:otherwise>
                                              =Fields!<xsl:value-of select="$tbName"/>.Value
                                            </xsl:otherwise>
                                          </xsl:choose>
                                        </Value>
                                        <Style>
                                          <FontFamily>Arial</FontFamily>
                                          <xsl:if test="Format != ''">
                                            <Format>
                                              <xsl:value-of select="Format"/>
                                            </Format>
                                          </xsl:if>                                                  
                                          <Color>#4d4d4d</Color>
                                        </Style>
                                      </TextRun>
                                    </TextRuns>
                                    <Style />
                                  </Paragraph>
                                </Paragraphs>
                                <rd:DefaultName><xsl:value-of select="$tbName"/></rd:DefaultName>
                                <Style>
                                  <Border>
                                    <Color>#e5e5e5</Color>
                                    <Style>Solid</Style>
                                  </Border>
                                  <PaddingLeft>2pt</PaddingLeft>
                                  <PaddingRight>2pt</PaddingRight>
                                  <PaddingTop>2pt</PaddingTop>
                                  <PaddingBottom>2pt</PaddingBottom>
                                </Style>
                              </Textbox>
                            </CellContents>
                          </TablixCell>
                        </xsl:for-each>
                      </TablixCells>
                    </TablixRow>
                  </TablixRows>

                </TablixBody>

                <TablixColumnHierarchy>
                  <TablixMembers>
                    <xsl:for-each select="Fields/FieldDef">
                      <TablixMember>
                        <xsl:if test="CheckVisibility = 'true'">
                          <Visibility>
                            <Hidden>
                              =Code.I_Logical.IsHidden(Parameters!ColumnVisibilityOptions.Value, "<xsl:value-of select="$DataSetName"/>.<xsl:value-of select="Name"/>")
                            </Hidden>
                          </Visibility>
                        </xsl:if>
                      </TablixMember>
                    </xsl:for-each>
                  </TablixMembers>
                </TablixColumnHierarchy>
                <TablixRowHierarchy>
                  <TablixMembers>
                    <TablixMember>
                      <KeepWithGroup>After</KeepWithGroup>
                      <RepeatOnNewPage>true</RepeatOnNewPage>
                      <KeepTogether>true</KeepTogether>
                    </TablixMember>
                    <TablixMember>
                      <Group Name="Details" />
                    </TablixMember>
                  </TablixMembers>
                </TablixRowHierarchy>
                <DataSetName>
                  <xsl:value-of select="$DataSetName"/>
                </DataSetName>
                <PageBreak>
                  <BreakLocation>End</BreakLocation>
                  <ResetPageNumber>true</ResetPageNumber>
                </PageBreak>
                <PageName>
                  <xsl:value-of select="$Title"  disable-output-escaping="yes"/>
                </PageName>
                <xsl:if test="count(Sorting/SortingProperty) > 0">
                  <SortExpressions>
                    <xsl:for-each select="Sorting/SortingProperty" >
                      <SortExpression>
                        <Value>
                          =IIF( Code.I_Logical.IsHidden(Parameters!ColumnVisibilityOptions.Value, "<xsl:value-of select="$DataSetName"/>.<xsl:value-of select="Name"/>"),0,Fields!<xsl:value-of select="Name"/>.Value)
                        </Value>
                        <xsl:if test="SortDirection = 'Desc'">
                          <Direction>Descending</Direction>
                        </xsl:if>
                      </SortExpression>
                    </xsl:for-each>
                  </SortExpressions>
                </xsl:if>
                <Top>0.45in</Top>
                <Height>0.5in</Height>
                <Width><xsl:value-of select="TotalWidth"/>in</Width>
                <Style>
                  <Border>
                    <Style>None</Style>
                  </Border>
                </Style>
              </Tablix>
            </ReportItems>

            <Height>0.5in</Height>
            <Style>
              <Border>
                <Style>None</Style>
              </Border>
            </Style>
          </Body>
          <Width><xsl:value-of select="TotalWidth"/>in</Width>
          <Page>
            <PageHeader>
              <Height>1.33in</Height>
              <PrintOnFirstPage>true</PrintOnFirstPage>
              <PrintOnLastPage>true</PrintOnLastPage>
              <ReportItems>
                <Textbox Name="ReportTitle">
                  <CanGrow>true</CanGrow>
                  <KeepTogether>true</KeepTogether>
                  <Paragraphs>
                    <Paragraph>
                      <TextRuns>
                        <TextRun>
                          <Value>
                            <xsl:value-of select="Title"/>
                          </Value>
                          <Style>
                            <FontSize>24pt</FontSize>
                            <FontWeight>Bold</FontWeight>
                            <Color>White</Color>
                          </Style>
                        </TextRun>
                      </TextRuns>
                      <Style>
                        <TextAlign>Left</TextAlign>
                      </Style>
                    </Paragraph>
                  </Paragraphs>
                  <rd:WatermarkTextbox>Title</rd:WatermarkTextbox>
                  <rd:DefaultName>ReportTitle</rd:DefaultName>
                  <Height>0.88in</Height>
                  <Width><xsl:value-of select="TotalWidth"/>in</Width>
                  <Style>
                    <Border>
                      <Color>#e5e5e5</Color>
                      <Style>None</Style>
                    </Border>
                    <TopBorder>
                      <Style>Solid</Style>
                    </TopBorder>
                    <VerticalAlign>Middle</VerticalAlign>
                    <PaddingLeft>2pt</PaddingLeft>
                    <PaddingRight>2pt</PaddingRight>
                    <PaddingTop>2pt</PaddingTop>
                    <PaddingBottom>2pt</PaddingBottom>
                  </Style>
                </Textbox>
              </ReportItems>
              <Style>
                <Border>
                  <Style>None</Style>
                </Border>
                <BackgroundColor>#035fa2</BackgroundColor>
              </Style>
            </PageHeader>
            <LeftMargin>0.5in</LeftMargin>
            <RightMargin>0.5in</RightMargin>
            <TopMargin>0.5in</TopMargin>
            <BottomMargin>0.5in</BottomMargin>
            <Style>
              <Border>
                <Style>None</Style>
              </Border>
            </Style>
          </Page>
        </ReportSection>
      </ReportSections>

      <ReportParameters>
        <ReportParameter Name="ColumnVisibilityOptions">
          <DataType>String</DataType>
          <DefaultValue>
            <Values>
              <Value>Enter Default Here</Value>
            </Values>
          </DefaultValue>
          <Prompt>ColumnVisibilityOptions</Prompt>
          <MultiValue>true</MultiValue>
        </ReportParameter>
        <ReportParameter Name="QueryID">
          <DataType>Integer</DataType>
          <Prompt>QueryID</Prompt>
        </ReportParameter>
        <ReportParameter Name="ScheduledReportId">
          <DataType>Integer</DataType>
          <DefaultValue>
            <Values>
              <Value>0</Value>
            </Values>
          </DefaultValue>
          <Prompt>ScheduledReportId</Prompt>
        </ReportParameter>
        <ReportParameter Name="DataSetName">
          <DataType>String</DataType>
          <DefaultValue>
            <Values>
              <Value>
                <xsl:value-of select="$DataSetName"  disable-output-escaping="yes"/>
              </Value>
            </Values>
          </DefaultValue>
          <Prompt>Data Set Name</Prompt>
          <Hidden>true</Hidden>
        </ReportParameter>
      </ReportParameters>
      <CodeModules>
        <CodeModule>UTrack.Report.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=387059ccd20c5d51</CodeModule>
      </CodeModules>
      <Classes>
        <Class>
          <ClassName>UTrack.Report.Helper.Logical</ClassName>
          <InstanceName>I_Logical</InstanceName>
        </Class>
      </Classes>
      <rd:ReportUnitType>Inch</rd:ReportUnitType>
      <rd:ReportID>
        <xsl:value-of select="Guid"  disable-output-escaping="yes"/>
      </rd:ReportID>
    </Report>
  </xsl:template>
</xsl:stylesheet>
