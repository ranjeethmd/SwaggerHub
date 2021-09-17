import React from 'react';
import { APILink } from './APILink'

export const Sidebar = ({ organizationConfig, definitionList, getOrganizationData, updateDefinitionLink, defaultDefinitionLink }) => {

    

    if (!definitionList) {
        getOrganizationData(organizationConfig.orgName)
    } 
    

    return (
        <div className="side-bar">           
            <div className="side-bar-body">
                <label>&lt;/&gt;</label>
                <ul>
                    {
                        (definitionList || [])
                            .filter(definition => definition.properties[4].value === "true")
                            .map((definition, i) => <li key={i}><APILink
                                apiLinkData={definition}
                                updateDefinitionLink={updateDefinitionLink}
                                defaultDefinitionLink={defaultDefinitionLink}
                            /></li>)
                    }
                </ul>
                
            </div>
        </div>
    )
}