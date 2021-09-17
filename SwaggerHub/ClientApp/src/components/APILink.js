import React from 'react';

export const APILink = ({ apiLinkData, updateDefinitionLink, defaultDefinitionLink}) => {
    let name = apiLinkData.name
    let apiLink = apiLinkData.properties[0].url  

    function handleClick() {
        updateDefinitionLink(apiLink);
    }

    return (
        <div className={(defaultDefinitionLink === apiLink) ? "api-link api-link-clicked" : "api-link"} onClick={() => handleClick()}>
            {name}
        </div>
    )
}